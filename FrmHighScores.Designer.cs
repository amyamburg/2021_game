
namespace _2021_game
{
    partial class FrmHighScores
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
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.lstBoxName = new System.Windows.Forms.ListBox();
            this.lstBoxScore = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Location = new System.Drawing.Point(37, 52);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(38, 13);
            this.LblPlayerName.TabIndex = 0;
            this.LblPlayerName.Text = "NAME";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(149, 52);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(44, 13);
            this.LblPlayerScore.TabIndex = 1;
            this.LblPlayerScore.Text = "SCORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player\'s Score";
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Pink;
            this.BtnReturn.Location = new System.Drawing.Point(306, 135);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(110, 34);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Return to Game";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lstBoxName
            // 
            this.lstBoxName.FormattingEnabled = true;
            this.lstBoxName.Location = new System.Drawing.Point(42, 167);
            this.lstBoxName.Name = "lstBoxName";
            this.lstBoxName.Size = new System.Drawing.Size(87, 199);
            this.lstBoxName.TabIndex = 8;
            // 
            // lstBoxScore
            // 
            this.lstBoxScore.FormattingEnabled = true;
            this.lstBoxScore.Location = new System.Drawing.Point(155, 167);
            this.lstBoxScore.Name = "lstBoxScore";
            this.lstBoxScore.Size = new System.Drawing.Size(89, 199);
            this.lstBoxScore.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(50, 398);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "label1";
            // 
            // FrmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(428, 536);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstBoxScore);
            this.Controls.Add(this.lstBoxName);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.LblPlayerName);
            this.Name = "FrmHighScores";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.FrmHighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ListBox lstBoxName;
        private System.Windows.Forms.ListBox lstBoxScore;
        private System.Windows.Forms.Label lblMessage;
    }
}