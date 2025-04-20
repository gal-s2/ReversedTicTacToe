namespace WinformsEx05
{
    partial class GameSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.PlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.BoardSizeLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.rowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.PlayerOneTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(25, 224);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(220, 27);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(25, 23);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(44, 13);
            this.PlayersLabel.TabIndex = 1;
            this.PlayersLabel.Text = "Players:";
            // 
            // PlayerCheckBox
            // 
            this.PlayerCheckBox.AutoSize = true;
            this.PlayerCheckBox.Location = new System.Drawing.Point(28, 93);
            this.PlayerCheckBox.Name = "PlayerCheckBox";
            this.PlayerCheckBox.Size = new System.Drawing.Size(67, 17);
            this.PlayerCheckBox.TabIndex = 1;
            this.PlayerCheckBox.Text = "Player 2:";
            this.PlayerCheckBox.UseVisualStyleBackColor = true;
            this.PlayerCheckBox.CheckedChanged += new System.EventHandler(this.PlayerCheckBox_CheckedChanged);
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(28, 61);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(48, 13);
            this.Player1Label.TabIndex = 8;
            this.Player1Label.Text = "Player 1:";
            // 
            // BoardSizeLabel
            // 
            this.BoardSizeLabel.AutoSize = true;
            this.BoardSizeLabel.Location = new System.Drawing.Point(25, 142);
            this.BoardSizeLabel.Name = "BoardSizeLabel";
            this.BoardSizeLabel.Size = new System.Drawing.Size(61, 13);
            this.BoardSizeLabel.TabIndex = 4;
            this.BoardSizeLabel.Text = "Board Size:";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(41, 176);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(37, 13);
            this.RowsLabel.TabIndex = 5;
            this.RowsLabel.Text = "Rows:";
            // 
            // rowsNumericUpDown
            // 
            this.rowsNumericUpDown.Location = new System.Drawing.Point(84, 174);
            this.rowsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowsNumericUpDown.Name = "rowsNumericUpDown";
            this.rowsNumericUpDown.Size = new System.Drawing.Size(36, 20);
            this.rowsNumericUpDown.TabIndex = 3;
            this.rowsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowsNumericUpDown.ValueChanged += new System.EventHandler(this.rowsNumericUpDown_ValueChanged);
            // 
            // colsNumericUpDown
            // 
            this.colsNumericUpDown.Location = new System.Drawing.Point(190, 174);
            this.colsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colsNumericUpDown.Name = "colsNumericUpDown";
            this.colsNumericUpDown.Size = new System.Drawing.Size(36, 20);
            this.colsNumericUpDown.TabIndex = 4;
            this.colsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colsNumericUpDown.ValueChanged += new System.EventHandler(this.colsNumericUpDown_ValueChanged);
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(147, 176);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(30, 13);
            this.ColsLabel.TabIndex = 8;
            this.ColsLabel.Text = "Cols:";
            // 
            // PlayerOneTextBox
            // 
            this.PlayerOneTextBox.Location = new System.Drawing.Point(115, 58);
            this.PlayerOneTextBox.Name = "PlayerOneTextBox";
            this.PlayerOneTextBox.Size = new System.Drawing.Size(130, 20);
            this.PlayerOneTextBox.TabIndex = 0;
            this.PlayerOneTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // PlayerTwoTextBox
            // 
            this.PlayerTwoTextBox.Enabled = false;
            this.PlayerTwoTextBox.Location = new System.Drawing.Point(115, 90);
            this.PlayerTwoTextBox.Name = "PlayerTwoTextBox";
            this.PlayerTwoTextBox.Size = new System.Drawing.Size(130, 20);
            this.PlayerTwoTextBox.TabIndex = 2;
            this.PlayerTwoTextBox.Text = "[Computer]";
            this.PlayerTwoTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 275);
            this.Controls.Add(this.PlayerTwoTextBox);
            this.Controls.Add(this.PlayerOneTextBox);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.colsNumericUpDown);
            this.Controls.Add(this.rowsNumericUpDown);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.BoardSizeLabel);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.PlayerCheckBox);
            this.Controls.Add(this.PlayersLabel);
            this.Controls.Add(this.StartButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.CheckBox PlayerCheckBox;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label BoardSizeLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.NumericUpDown rowsNumericUpDown;
        private System.Windows.Forms.NumericUpDown colsNumericUpDown;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.TextBox PlayerOneTextBox;
        private System.Windows.Forms.TextBox PlayerTwoTextBox;
    }
}

