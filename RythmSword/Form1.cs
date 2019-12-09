using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RythmSword
{
    public partial class Form1 : Form
    {
        static public Random Rnd = new Random();
        static public Timer GameTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black;

            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                Balls[i].MoveBall();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
            SpawnBall();
        }

        static public List<Ball> Balls = new List<Ball>();


        private void SpawnBall()
        {
            short direction = 0;
            switch (Rnd.Next(0, 2))
            {
                case 0: Balls.Add(new Ball( new Point(0, Height / 2) ));
                    direction = 1;
                    break;
                //case 1: Balls.Add(new Ball( new Point(Width / 2, 0) )); break;
                case 1: Balls.Add(new Ball( new Point(Width - 65, Height / 2) ));
                    direction = -1;
                    break;
            }

            Ball ball = Balls[Balls.Count - 1];
            ball.Direction = direction;
            

            Controls.Add(ball.Picture);
        }
    }
}
