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

        /// <summary>
        /// Move to the next form of the game where the user inputs their name and selects
        /// levels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Player form1 = new Player();
            form1.Show();
            this.Hide();
        }

        /// <summary>
        /// Open the instructions form and hide this one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            Instructions form2 = new Instructions();
            form2.Show();
            this.Hide();
        }

        /// <summary>
        /// Open the high score form and hide this one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHighScore_Click(object sender, EventArgs e)
        {
            HighScores form3 = new HighScores();
            form3.Show();
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
