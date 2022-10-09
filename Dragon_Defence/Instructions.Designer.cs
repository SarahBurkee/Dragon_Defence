namespace Dragon_Defence
{
    partial class Instructions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instructions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "The aim of Dragon Defence is to...";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.LightGray;
            this.BtnBack.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(97, 35);
            this.BtnBack.TabIndex = 4;
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
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dragon_Defence.Properties.Resources.backgroundfitting;
            this.ClientSize = new System.Drawing.Size(1013, 661);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
    }
}