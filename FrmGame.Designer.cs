
namespace _2021_game
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrCupcake = new System.Windows.Forms.Timer(this.components);
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.TmrLettuce = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.Location = new System.Drawing.Point(0, 86);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(484, 475);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseMove);
            // 
            // TmrCupcake
            // 
            this.TmrCupcake.Enabled = true;
            this.TmrCupcake.Tick += new System.EventHandler(this.TmrCupcake_Tick);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(170, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(349, 50);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(123, 23);
            this.BtnCheck.TabIndex = 5;
            this.BtnCheck.Text = "Check For High Score";
            this.BtnCheck.UseVisualStyleBackColor = true;
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(412, 15);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(60, 23);
            this.BtnQuit.TabIndex = 6;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lives";
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(346, 15);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(13, 13);
            this.LblLives.TabIndex = 8;
            this.LblLives.Text = "3";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(179, 53);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
            this.LblScore.TabIndex = 9;
            this.LblScore.Text = "0";
            // 
            // TmrLettuce
            // 
            this.TmrLettuce.Enabled = true;
            this.TmrLettuce.Tick += new System.EventHandler(this.TmrLettuce_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.PnlGame);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrCupcake;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Timer TmrLettuce;
    }
}

