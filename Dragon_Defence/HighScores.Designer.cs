namespace Dragon_Defence
{
    partial class HighScores
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.LightGray;
            this.BtnBack.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(97, 35);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightGray;
            this.BtnExit.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(904, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 35);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dragon_Defence.Properties.Resources.backgroundfitting;
            this.ClientSize = new System.Drawing.Size(1013, 661);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.DoubleBuffered = true;
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
    }
}