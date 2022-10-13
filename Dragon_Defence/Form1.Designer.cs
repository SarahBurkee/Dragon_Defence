namespace Dragon_Defence
{
    partial class Form1
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
            this.tmrDragon = new System.Windows.Forms.Timer(this.components);
            this.tmrMonster = new System.Windows.Forms.Timer(this.components);
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.LblStrength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDifficulty = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDragon
            // 
            this.tmrDragon.Interval = 50;
            this.tmrDragon.Tick += new System.EventHandler(this.tmrDragon_Tick);
            // 
            // tmrMonster
            // 
            this.tmrMonster.Tick += new System.EventHandler(this.tmrMonster_Tick);
            // 
            // tmrShoot
            // 
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlGame.BackgroundImage = global::Dragon_Defence.Properties.Resources.gamebackgroundfitting;
            this.PnlGame.Controls.Add(this.LblStrength);
            this.PnlGame.Controls.Add(this.label6);
            this.PnlGame.Controls.Add(this.BtnPause);
            this.PnlGame.Controls.Add(this.BtnPlay);
            this.PnlGame.Controls.Add(this.label4);
            this.PnlGame.Controls.Add(this.LblDifficulty);
            this.PnlGame.Controls.Add(this.LblTimer);
            this.PnlGame.Controls.Add(this.LblScore);
            this.PnlGame.Controls.Add(this.label3);
            this.PnlGame.Controls.Add(this.LblName);
            this.PnlGame.Controls.Add(this.label1);
            this.PnlGame.Controls.Add(this.label2);
            this.PnlGame.Controls.Add(this.BtnBack);
            this.PnlGame.Location = new System.Drawing.Point(-8, -20);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1027, 700);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // LblStrength
            // 
            this.LblStrength.AutoSize = true;
            this.LblStrength.BackColor = System.Drawing.Color.Transparent;
            this.LblStrength.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStrength.Location = new System.Drawing.Point(758, 31);
            this.LblStrength.Name = "LblStrength";
            this.LblStrength.Size = new System.Drawing.Size(56, 31);
            this.LblStrength.TabIndex = 19;
            this.LblStrength.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Castle Strength:";
            // 
            // BtnPause
            // 
            this.BtnPause.BackColor = System.Drawing.Color.LightGray;
            this.BtnPause.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPause.Location = new System.Drawing.Point(20, 104);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(92, 30);
            this.BtnPause.TabIndex = 17;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.LightGray;
            this.BtnPlay.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(20, 68);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(92, 30);
            this.BtnPlay.TabIndex = 16;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Difficulty:";
            // 
            // LblDifficulty
            // 
            this.LblDifficulty.AutoSize = true;
            this.LblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.LblDifficulty.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDifficulty.Location = new System.Drawing.Point(244, 32);
            this.LblDifficulty.Name = "LblDifficulty";
            this.LblDifficulty.Size = new System.Drawing.Size(107, 31);
            this.LblDifficulty.TabIndex = 14;
            this.LblDifficulty.Text = "difficulty";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.BackColor = System.Drawing.Color.Transparent;
            this.LblTimer.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.Location = new System.Drawing.Point(432, 29);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(28, 31);
            this.LblTimer.TabIndex = 13;
            this.LblTimer.Text = "0";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.Color.Transparent;
            this.LblScore.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(540, 30);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(28, 31);
            this.LblScore.TabIndex = 12;
            this.LblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(220, 68);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 31);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Timer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.LightGray;
            this.BtnBack.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(20, 32);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(92, 30);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 661);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDifficulty;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Timer tmrDragon;
        private System.Windows.Forms.Timer tmrMonster;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Label LblStrength;
        private System.Windows.Forms.Label label6;
    }
}

