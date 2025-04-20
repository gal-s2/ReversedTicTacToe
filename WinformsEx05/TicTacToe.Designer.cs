namespace WinformsEx05
{
    partial class TicTacToe
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
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.ComputerScoreLabel = new System.Windows.Forms.Label();
            this.ContainingPanel = new System.Windows.Forms.Panel();
            this.LabelsPanel = new System.Windows.Forms.Panel();
            this.LabelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(21, 17);
            this.PlayerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(69, 20);
            this.PlayerScoreLabel.TabIndex = 0;
            this.PlayerScoreLabel.Text = "Player 1:";
            // 
            // ComputerScoreLabel
            // 
            this.ComputerScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerScoreLabel.AutoSize = true;
            this.ComputerScoreLabel.Location = new System.Drawing.Point(154, 17);
            this.ComputerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComputerScoreLabel.Name = "ComputerScoreLabel";
            this.ComputerScoreLabel.Size = new System.Drawing.Size(83, 20);
            this.ComputerScoreLabel.TabIndex = 1;
            this.ComputerScoreLabel.Text = "Computer:";
            // 
            // ContainingPanel
            // 
            this.ContainingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainingPanel.Location = new System.Drawing.Point(18, 18);
            this.ContainingPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContainingPanel.Name = "ContainingPanel";
            this.ContainingPanel.Size = new System.Drawing.Size(640, 623);
            this.ContainingPanel.TabIndex = 2;
            // 
            // LabelsPanel
            // 
            this.LabelsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelsPanel.Controls.Add(this.PlayerScoreLabel);
            this.LabelsPanel.Controls.Add(this.ComputerScoreLabel);
            this.LabelsPanel.Location = new System.Drawing.Point(189, 651);
            this.LabelsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelsPanel.Name = "LabelsPanel";
            this.LabelsPanel.Size = new System.Drawing.Size(276, 48);
            this.LabelsPanel.TabIndex = 3;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 702);
            this.Controls.Add(this.LabelsPanel);
            this.Controls.Add(this.ContainingPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(690, 731);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.LabelsPanel.ResumeLayout(false);
            this.LabelsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.Label ComputerScoreLabel;
        private System.Windows.Forms.Panel ContainingPanel;
        private System.Windows.Forms.Panel LabelsPanel;
    }
}