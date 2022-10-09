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
    public partial class Player : Form
    {
        string playerName;

        public Player()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the home button is clicked take the user to the first (home) form of the 
        /// game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormStartup form = new FormStartup();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Remove this button?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$")) // Checks playerName for letters.
            {
                // If playerName valid (only letters) show the game form and hide this one.
                Form1 form4 = new Form1();
                form4.Show();
                this.Hide();
            }

            else
            {
                // If playerName is invalid, clear txtName and focus on it to try again.
                MessageBox.Show("Please enter a valid name, this textbox only accepts alphabetical characters.");
                TxtName.Clear();
                TxtName.Focus();
            }
        }

        /// <summary>
        /// When the button is clicked check that the player's name is valid and set up
        /// the game in regards to the difficulty level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEasy_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$")) // Checks playerName for letters.
            {
                // If playerName valid (only letters) show the game form and hide this one.
                Form1 form4 = new Form1();
                form4.Show();
                this.Hide();
            }

            else
            {
                // If playerName is invalid, clear txtName and focus on it to try again.
                MessageBox.Show("Please enter a valid name, this textbox only accepts alphabetical characters.");
                TxtName.Clear();
                TxtName.Focus();
            }
        }

        /// <summary>
        /// When the button is clicked check that the player's name is valid and set up
        /// the game in regards to the difficulty level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMedium_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$")) // Checks playerName for letters.
            {
                // If playerName valid (only letters) show the game form and hide this one.
                Form1 form4 = new Form1();
                form4.Show();
                this.Hide();
            }

            else
            {
                // If playerName is invalid, clear txtName and focus on it to try again.
                MessageBox.Show("Please enter a valid name, this textbox only accepts alphabetical characters.");
                TxtName.Clear();
                TxtName.Focus();
            }
        }

        /// <summary>
        /// When the button is clicked check that the player's name is valid and set up
        /// the game in regards to the difficulty level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHard_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$")) // Checks playerName for letters.
            {
                // If playerName valid (only letters) show the game form and hide this one.
                Form1 form4 = new Form1();
                form4.Show();
                this.Hide();
            }

            else
            {
                // If playerName is invalid, clear txtName and focus on it to try again.
                MessageBox.Show("Please enter a valid name, this textbox only accepts alphabetical characters.");
                TxtName.Clear();
                TxtName.Focus();
            }
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
