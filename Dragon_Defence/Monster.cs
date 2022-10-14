using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Dragon_Defence
{
    internal class Monster
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image monsterImage;//variable for the marshmallow's image

        public Rectangle monsterRec;//variable for a rectangle to place our image in

        // Methods for the Marshmallow class
        public void DrawMonster(Graphics g)
        {
            monsterRec = new Rectangle(x, y, width, height);
            g.DrawImage(monsterImage, monsterRec);
        }

        public void MoveMonster()
        {
            monsterRec.Location = new Point(x, y);
        }


        //Create a constructor (initialises the values of the fields)
        public Monster(int displacement)
        {
            x = 10;
            y = displacement;
            width = 110;
            height = 80;
            //planetImage contains the marshmallow.png image
            monsterImage = Properties.Resources.goowingfinal;
            monsterRec = new Rectangle(x, y, width, height);
        }
    }
}
