using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RythmSword
{
    public class Ball
    {
        public Ball(Point loc)
        {
            Picture.Location =  loc;
            Picture.Size = new Size(50, 50);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.ImageLocation = @"img/ball.png";
        }

        public PictureBox Picture = new PictureBox();
        public uint Speed = 5;
        public short Direction;

        public void MoveBall()
        {
            Picture.Location = new Point
            {
                X = Picture.Location.X + (int)(Speed * Direction),
                Y = Picture.Location.Y
            };
        }
    }

    
}
