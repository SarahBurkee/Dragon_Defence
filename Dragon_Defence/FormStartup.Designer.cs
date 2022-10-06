namespace Dragon_Defence
{
    partial class FormStartup
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
            this.BtnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInstructions = new System.Windows.Forms.Button();
            this.BtnHighScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.LightGray;
            this.BtnPlay.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(425, 320);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(160, 49);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dragon Defence";
            // 
            // BtnInstructions
            // 
            this.BtnInstructions.BackColor = System.Drawing.Color.LightGray;
            this.BtnInstructions.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstructions.Location = new System.Drawing.Point(425, 486);
            this.BtnInstructions.Name = "BtnInstructions";
            this.BtnInstructions.Size = new System.Drawing.Size(160, 49);
            this.BtnInstructions.TabIndex = 2;
            this.BtnInstructions.Text = "Instructions";
            this.BtnInstructions.UseVisualStyleBackColor = false;
            this.BtnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            // 
            // BtnHighScore
            // 
            this.BtnHighScore.BackColor = System.Drawing.Color.LightGray;
            this.BtnHighScore.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHighScore.Location = new System.Drawing.Point(425, 403);
            this.BtnHighScore.Name = "BtnHighScore";
            this.BtnHighScore.Size = new System.Drawing.Size(160, 49);
            this.BtnHighScore.TabIndex = 3;
            this.BtnHighScore.Text = "High Score";
            this.BtnHighScore.UseVisualStyleBackColor = false;
            this.BtnHighScore.Click += new System.EventHandler(this.BtnHighScore_Click);
            // 
            // FormStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Dragon_Defence.Properties.Resources.backgroundfitting;
            this.ClientSize = new System.Drawing.Size(1011, 661);
            this.Controls.Add(this.BtnHighScore);
            this.Controls.Add(this.BtnInstructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlay);
            this.DoubleBuffered = true;
            this.Name = "FormStartup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStartup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInstructions;
        private System.Windows.Forms.Button BtnHighScore;
    }
}