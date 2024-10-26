using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake_game
{
    public partial class Form1 : Form
    {
        private Snake snake;
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;
        int score;
        int highScore;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;

        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                snake.ChangeDirection("left");
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                snake.ChangeDirection("right");
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                snake.ChangeDirection("up");
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                snake.ChangeDirection("down");
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (snake != null)
            {
                snake.Move();

                Circle head = snake.GetSnakeBody()[0];
                if (head.X == food.X && head.Y == food.Y)
                {
                    EatFood();
                }

                for (int i = 1; i < snake.GetSnakeBody().Count; i++)
                {
                    if (head.X == snake.GetSnakeBody()[i].X && head.Y == snake.GetSnakeBody()[i].Y)
                    {
                        GameOver();
                    }
                }
            }

            picCanvas.Invalidate();
        }


        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (snake != null)
            {
                Brush snakeColour;
                foreach (Circle segment in snake.GetSnakeBody())
                {
                    if (segment == snake.GetSnakeBody()[0])
                    {
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        snakeColour = Brushes.DarkGreen;
                    }
                    canvas.FillEllipse(snakeColour, new Rectangle
                        (
                        segment.X * Settings.Width,
                        segment.Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));
                }
            }

            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }


        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;
            snake = new Snake(maxWidth, maxHeight);
            startButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            gameTimer.Start();
        }



        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;
            snake.GetSnakeBody().Add(new Circle
            {
                X = snake.GetSnakeBody()[snake.GetSnakeBody().Count - 1].X,
                Y = snake.GetSnakeBody()[snake.GetSnakeBody().Count - 1].Y
            });
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;
            if (score > highScore)
            {
                highScore = score;
                txtHighScore.Text = "High Score: " + highScore;
            }
        }
    }
}
