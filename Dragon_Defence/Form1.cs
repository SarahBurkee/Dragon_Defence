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
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form

        Random yspeed = new Random();
        Dragon dragon = new Dragon(); //create an instance of the Dragon Class called dragon
        //declare a list fire from the Fire class
        List<Fire> fire = new List<Fire>();
        List<Monster> monster = new List<Monster>();


        bool left, right, down, up;
        int score, strength;
        string move;

        public Form1(string name, string levels)
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty
           | System.Reflection.BindingFlags.Instance
           | System.Reflection.BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            // Sets the name that the user entered onto the label.
            LblName.Text = name;
            // Sets the level of difficulty that the user entered onto the label.
            LblDifficulty.Text = levels;

            if (levels == "Easy")
            {
                strength = 1000;
            }
            else if (levels == "Medium")
            {
                strength = 500;
            }
            else if (levels == "Hard")
            {
                strength = 100;
            }

            LblStrength.Text = strength.ToString();

            for (int i = 0; i < 9; i++)
            {
                int displacement = 10 + (i * 75);

                monster.Add(new Monster(displacement));
            }

        }
        private void CheckScore()
        {
            if (score == 50)
            {
                tmrMonster.Enabled = false;
                tmrDragon.Enabled = false;
                tmrShoot.Enabled = false;

            }
        }

        private void CheckStrength()
        {
            if (strength == 0)
            {
                tmrMonster.Enabled = false;
                tmrDragon.Enabled = false;
                tmrShoot.Enabled = false;
               
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            // get the graphics used to paint on the Form control
            g = e.Graphics;

            for (int i = 0; i < 9; i++)
            {
                // generate a random number from 4 to 8 and put it in rndmspeed
                int rndmspeed = yspeed.Next(2, 15);
                monster[i].x += rndmspeed;


                //call the Planet class's drawPlanet method to draw the images
                monster[i].DrawMonster(g);
                dragon.drawDragon(g);
            }

            foreach (Fire m in fire)
            {
                m.drawFire(g);
                m.moveFire(g);
            }
        }

        /// <summary>
        /// When the back button is clicked take the user to the last form they were on 
        /// (the player form).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Player form1 = new Player();
            form1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            // pass lives from LblLives Text property to lives variable
            strength = int.Parse(LblStrength.Text);

            tmrDragon.Enabled = true;
            tmrMonster.Enabled = true;
            tmrShoot.Enabled = true;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

        }

        private void tmrDragon_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";

                dragon.moveDragon(move);
            }

            if (left) // if left arrow key pressed
            {
                move = "left";
                dragon.moveDragon(move);
            }

            if (down) // if down arrow key pressed
            {
                move = "down";

                dragon.moveDragon(move);
            }

            if (up) // if up arrow key pressed
            {
                move = "up";

                dragon.moveDragon(move);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;

            }

            if (e.KeyCode == Keys.Right)
            {
                right = true;

            }

            if (e.KeyCode == Keys.Down)
            {
                down = true;

            }

            if (e.KeyCode == Keys.Up)
            {
                up = true;

            }

            if (e.KeyCode == Keys.Space)
            {                
                    fire.Add(new Fire(dragon.dragonRec, dragon.rotationAngle));
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Right) { right = false; }
        }

        private void tmrMonster_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                //if a marshmallow reaches the bottom of the Game Area reposition it at the top
                if (monster[i].x >= PnlGame.Width)
                {
                    strength -= 1;// lose a life
                    LblStrength.Text = strength.ToString();// display number of lives
                    CheckStrength();
                    monster[i].x = 30;
                }
            }

            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Fire m in fire) // for movement and updating the score and lives for marshmallows
            {
                foreach (Monster p in monster) // for movement and updating the score and lives for marshmallows

                {
                    if (p.monsterRec.IntersectsWith(m.fireRec))
                    {
                        score += 1;// update the score
                        CheckScore();
                        LblScore.Text = score.ToString();// display score

                        p.y = 0;

                        m.killFire(g); // move fire so it's out of the game panel
                        break;

                    }
                }
            }


            PnlGame.Invalidate();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            tmrDragon.Enabled = false;
            tmrMonster.Enabled = false;
            tmrShoot.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
