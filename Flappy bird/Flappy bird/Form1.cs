using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 9;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            upperPipe.Left -= pipeSpeed;
            downerPipe.Left -= pipeSpeed;
            label1.Text = "Score : " + score;
            if (downerPipe.Left < -150)
            {
                downerPipe.Left = 800;
                score++;
            }
            if (upperPipe.Left < -180)
            {
                upperPipe.Left = 950;
                score++; 
            }
            if(flappyBird.Bounds.IntersectsWith(upperPipe.Bounds) || flappyBird.Bounds.IntersectsWith(downerPipe.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Bounds.IntersectsWith(sky.Bounds))
            {
                endGame();
            }
        }

        private void gameKeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -9;
            }
        }

        private void gameKeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 9;
            }
        }
        private void endGame()
        {
            timer1.Stop();
            label1.Text = "Game Over ! you'r score was (" + score + ")" ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
