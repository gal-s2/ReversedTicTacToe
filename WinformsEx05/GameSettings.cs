namespace WinformsEx05
{
    using System;
    using System.Windows.Forms;

    public partial class GameSettings : Form
    {
        private TicTacToe m_TicTacToe;
        private byte m_NumberOfPlayers = 1;
        private byte m_BoardSize = 4;

        public GameSettings()
        {
            InitializeComponent();
        }

        public byte NumberOfPlayers
        {
            get
            {
                return m_NumberOfPlayers;
            }
        }

        public byte BoardSize
        {
            get
            {
                return m_BoardSize;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(PlayerCheckBox.Checked == false)
            {
                PlayerTwoTextBox.Text = "Computer";
            }
            m_TicTacToe = new TicTacToe(BoardSize, NumberOfPlayers, PlayerOneTextBox.Text, PlayerTwoTextBox.Text);
            this.Close();
        }
        private void PlayerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(this.PlayerCheckBox.Checked)
            {
                this.PlayerTwoTextBox.Enabled = true;
                this.PlayerTwoTextBox.Text = "";
                m_NumberOfPlayers = 2;
            }
            else
            {
                this.PlayerTwoTextBox.Enabled = false;
                this.PlayerTwoTextBox.Text = "[Computer]";
                m_NumberOfPlayers = 1;
            }
        }

        private void colsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.rowsNumericUpDown.Value = this.colsNumericUpDown.Value;
            m_BoardSize = (byte)this.colsNumericUpDown.Value;
        }

        private void rowsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.colsNumericUpDown.Value = this.rowsNumericUpDown.Value;
            m_BoardSize = (byte)this.colsNumericUpDown.Value;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(PlayerCheckBox.Checked)
            {
                if(string.IsNullOrEmpty(PlayerOneTextBox.Text) || string.IsNullOrEmpty(PlayerTwoTextBox.Text))
                {
                    StartButton.Enabled = false;
                }
                else
                {
                    StartButton.Enabled = true;
                }
            }
            else if(string.IsNullOrEmpty(PlayerOneTextBox.Text))
            {
                StartButton.Enabled = false;
            }
            else
            {
                StartButton.Enabled = true;
            }
        }
    }
}