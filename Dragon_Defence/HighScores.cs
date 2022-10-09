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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When back button is click show the first (home) form of the game and hide this one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormStartup form = new FormStartup();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
