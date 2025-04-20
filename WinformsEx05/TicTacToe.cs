namespace WinformsEx05
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Logics;
    public partial class TicTacToe : Form
    {
        private readonly GameEntity r_GameEntity;
        private const string k_FirstPlayerSign = "X";
        private const string k_SecondPlayerSign = "O";

        public TicTacToe(byte i_BoardSize, byte i_NumberOfPlayers, string i_FirstPlayerName, string i_SecondPlayerName)
        {
            InitializeComponent();
            r_GameEntity = new GameEntity(i_BoardSize, i_NumberOfPlayers);
            r_GameEntity.PlayerOne.Name = i_FirstPlayerName;
            r_GameEntity.PlayerTwo.Name = i_SecondPlayerName;
            ShowDialog();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            AddTableLayoutPanel();
            updateScoreLabels();
        }

        private void AddTableLayoutPanel()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = tableLayoutPanel.ColumnCount = r_GameEntity.SizeOfBoard;
            tableLayoutPanel.Dock = DockStyle.Fill;

            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tableLayoutPanel.RowCount));
            }

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / tableLayoutPanel.ColumnCount));
            }

            for (byte row = 0; row < tableLayoutPanel.RowCount; row++)
            {
                for (byte col = 0; col < tableLayoutPanel.ColumnCount; col++)
                {
                    Button button = new Button()
                    {
                        Name = string.Format("Button_{0}{1}", row, col),
                        Dock = DockStyle.Fill,
                        BackColor = SystemColors.ButtonFace,
                        Enabled = true,
                        Size = new Size(50, 50),
                        Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left,
                        TabStop = false,
                        Tag = new Coordinate(row, col)
                    };

                    button.Click += onCoordinateClick;
                    tableLayoutPanel.Controls.Add(button, col, row);
                }
            }
            ContainingPanel.Controls.Add(tableLayoutPanel);
        }

        private void updateScoreLabels()
        { 
            PlayerScoreLabel.Text = $"{r_GameEntity.PlayerOne.Name}: {r_GameEntity.PlayerOne.CurrentScore}";
            ComputerScoreLabel.Text = $"{r_GameEntity.PlayerTwo.Name}: {r_GameEntity.PlayerTwo.CurrentScore}";
        }

        private void onCoordinateClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            button.Text = r_GameEntity.CurrentPlayer.PlayerToken == 1 ? k_FirstPlayerSign : k_SecondPlayerSign;
            button.Enabled = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;

            r_GameEntity.AddTokenToMatrix((Coordinate)button.Tag, r_GameEntity.CurrentPlayer.PlayerToken);

            Player winner = r_GameEntity.IsGameEndedWithWinner((Coordinate)button.Tag, r_GameEntity.CurrentPlayer.PlayerToken);
            
            GameLogicDivider(e, winner); 
        }

        private void resetButtons()
        {
            Button currentButton;

            for (byte row = 0; row < r_GameEntity.SizeOfBoard; row++)
            {
                for (byte col = 0; col < r_GameEntity.SizeOfBoard; col++)       
                {
                    currentButton = ContainingPanel.Controls.Find($"Button_{row}{col}", true).FirstOrDefault() as Button;
                    currentButton.Text = "";
                    currentButton.Enabled = true;
                    currentButton.FlatStyle = FlatStyle.Standard;
                    currentButton.FlatAppearance.BorderSize = 0;
                }
            }
        }

        public void GameWinLogic(Player i_Winner)
        {
            i_Winner.CurrentScore++;
            updateScoreLabels();

            if (MessageBox.Show($"The Winner is {i_Winner.Name}{Environment.NewLine}Would you like to play another round?", "A Win!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resetButtons();
                r_GameEntity.ResetGame();
            }
            else
            {
                Close();
            }
        }

        public void GameTieLogic()
        {
            r_GameEntity.PlayerOne.CurrentScore++;
            r_GameEntity.PlayerTwo.CurrentScore++;
            updateScoreLabels();

            if (MessageBox.Show($"Tie!{Environment.NewLine}Would you like to play another round?", "A Tie!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resetButtons();
                r_GameEntity.ResetGame();
            }
            else
            {
                Close();
            }
        }

        public void GameContinuationHandlerLogic(EventArgs i_Event)
        {
            r_GameEntity.SwitchTurn();

            if (r_GameEntity.CurrentPlayer.IsBot)
            {
                Coordinate coordinate = r_GameEntity.GameBoard.GetCoordinateSpotFromAvailable();
                onCoordinateClick(ContainingPanel.Controls.Find($"Button_{coordinate.x}{coordinate.y}", true).FirstOrDefault() as Button, i_Event);
            }
        }

        public void GameLogicDivider(EventArgs i_Event, Player i_Winner)
        {
            if (i_Winner != null)
            {
                GameWinLogic(i_Winner);
            }
            else if (r_GameEntity.IsBoardFull())
            {
                GameTieLogic();
            }
            else
            {
                GameContinuationHandlerLogic(i_Event);
            }
        }
    }
}