using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake_game
{
    class Snake
    {
        private List<Circle> snakeBody;
        private int maxWidth;
        private int maxHeight;
        private string direction;

        public Snake(int maxWidth, int maxHeight)
        {
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            snakeBody = new List<Circle>();
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            Circle head = new Circle { X = 10, Y = 5 };
            snakeBody.Add(head);
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                snakeBody.Add(body);
            }
            direction = "left";
        }

        public void Move()
        {
            for (int i = snakeBody.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (direction)
                    {
                        case "left":
                            snakeBody[i].X--;
                            break;
                        case "right":
                            snakeBody[i].X++;
                            break;
                        case "down":
                            snakeBody[i].Y++;
                            break;
                        case "up":
                            snakeBody[i].Y--;
                            break;
                    }
                    //move from one side to another
                    snakeBody[i].X = (snakeBody[i].X + maxWidth) % maxWidth;
                    snakeBody[i].Y = (snakeBody[i].Y + maxHeight) % maxHeight;
                }
                else
                {
                    snakeBody[i].X = snakeBody[i - 1].X;
                    snakeBody[i].Y = snakeBody[i - 1].Y;
                }
            }
        }

        public void ChangeDirection(string newDirection)
        {
            if ((direction != "left" && newDirection == "right") ||
                (direction != "right" && newDirection == "left") ||
                (direction != "up" && newDirection == "down") ||
                (direction != "down" && newDirection == "up"))
            {
                direction = newDirection;
            }
        }

        //allowing other classes to use this class
        public List<Circle> GetSnakeBody()
        {
            return snakeBody;
        }
    }
}
