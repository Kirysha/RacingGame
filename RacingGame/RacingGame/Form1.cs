using RacingGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        GameLogic game = new GameLogic();

        public Form1()
        {
            InitializeComponent();
            
            DoubleBuffered = true;
            game.GameStart();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, PlayButton.Width, PlayButton.Height);
            Region rgn = new Region(path);
            PlayButton.Region = rgn;
            PlayButton.BackColor = Color.FromArgb(0, 0, 0, 0); 

        }

        private void road1_Paint(object sender, PaintEventArgs e)
        {
            var road1 = e.Graphics;
            road1.DrawImage((Image)Resources.Road, game.road1.coord.x, game.road1.coord.y, 482f,753f);

            var road2 = e.Graphics;
            road1.DrawImage((Image)Resources.Road, game.road2.coord.x, game.road2.coord.y, 482f, 753f);

            var player = e.Graphics;
            if (game.bost)
            {
                player.DrawImage((Image)Resources.car_hight_fire, game.player.cord.x, game.player.cord.y);
            }
            else
            {
                player.DrawImage((Image)Resources.car_hight, game.player.cord.x, game.player.cord.y);
            }
            List<Graphics> graphics = new List<Graphics>();
            for (int i=0; i<game.barriers.Count; i++)
            {
                graphics.Add(e.Graphics);
                if (game.barriers[i] is car)
                {
                    graphics[i].DrawImage((Image)Resources.car_barrier, game.barriers[i].coord.x, game.barriers[i].coord.y);
                }
                else
                {
                    if (game.barriers[i] is Boost)
                    {
                        graphics[i].DrawImage((Image)Resources.rockets1, game.barriers[i].coord.x, game.barriers[i].coord.y);
                    }
                    else
                    {
                        graphics[i].DrawImage((Image)Resources.barrier, game.barriers[i].coord.x, game.barriers[i].coord.y);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game.GameOver)
            {
                timer1.Enabled = false;
                GameStart.Visible = true;
                textGameOver.Visible = true;
            }
            game.Game();
            road.Invalidate();
            Score_point.Text = game.score.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Left || e.KeyChar == 97 || e.KeyChar == 1060 || e.KeyChar == 1092 || e.KeyChar == 65)
                game.Move_Player_Left();
            if (e.KeyChar == (char)Keys.Right || e.KeyChar == 100 || e.KeyChar == 1074 || e.KeyChar == 68 || e.KeyChar == 1042)
                game.Move_Player_Right();
        }

        private void PlayButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage((Image)Resources.Play_logo, 30, 30,100,100);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            GameStart.Visible = false;
            textGameOver.Visible = false;
            game.GameStart();
            game.Game();
        }
    }
}
