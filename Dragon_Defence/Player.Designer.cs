namespace Dragon_Defence
{
    partial class Player
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
            this.BtnHome = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEasy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMedium = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.LightGray;
            this.BtnHome.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(12, 12);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(97, 35);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(423, 246);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(166, 20);
            this.TxtName.TabIndex = 6;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Player Name:";
            // 
            // BtnEasy
            // 
            this.BtnEasy.BackColor = System.Drawing.Color.LightGray;
            this.BtnEasy.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEasy.ForeColor = System.Drawing.Color.Black;
            this.BtnEasy.Location = new System.Drawing.Point(350, 383);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(90, 80);
            this.BtnEasy.TabIndex = 9;
            this.BtnEasy.Text = "Easy";
            this.BtnEasy.UseVisualStyleBackColor = false;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Difficulty:";
            // 
            // BtnMedium
            // 
            this.BtnMedium.BackColor = System.Drawing.Color.LightGray;
            this.BtnMedium.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedium.ForeColor = System.Drawing.Color.Black;
            this.BtnMedium.Location = new System.Drawing.Point(461, 383);
            this.BtnMedium.Name = "BtnMedium";
            this.BtnMedium.Size = new System.Drawing.Size(90, 80);
            this.BtnMedium.TabIndex = 11;
            this.BtnMedium.Text = "Medium";
            this.BtnMedium.UseVisualStyleBackColor = false;
            this.BtnMedium.Click += new System.EventHandler(this.BtnMedium_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.BackColor = System.Drawing.Color.LightGray;
            this.BtnHard.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHard.ForeColor = System.Drawing.Color.Black;
            this.BtnHard.Location = new System.Drawing.Point(572, 383);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(90, 80);
            this.BtnHard.TabIndex = 12;
            this.BtnHard.Text = "Hard";
            this.BtnHard.UseVisualStyleBackColor = false;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightGray;
            this.BtnExit.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(904, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 35);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Dragon_Defence.Properties.Resources.backgroundfitting;
            this.ClientSize = new System.Drawing.Size(1013, 661);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHard);
            this.Controls.Add(this.BtnMedium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEasy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnHome);
            this.DoubleBuffered = true;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMedium;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Button BtnExit;
    }
}