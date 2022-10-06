using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dragon_Defence
{
    public partial class FormStartup : Form
    {
        public FormStartup()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Player form1 = new Player();
            form1.Show();
            this.Hide();
        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            Instructions form2 = new Instructions();
            form2.Show();
            this.Hide();
        }

        private void BtnHighScore_Click(object sender, EventArgs e)
        {
            HighScores form3 = new HighScores();
            form3.Show();
            this.Hide();
        }
    }
}
