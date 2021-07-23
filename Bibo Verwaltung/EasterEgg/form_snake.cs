using Bibo_Verwaltung.Helper;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung.EasterEgg
{
    public partial class form_snake : MetroForm
    {
        Color fc = ColorTranslator.FromHtml("#ffb0b0");
        Color bc = Color.White;
        Color headColor = Color.Black;
        Color bodyColor = Color.DimGray;
        Color foodColor = Color.Crimson;
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public form_snake()
        {
            InitializeComponent();
            LoadTheme();

            //Default Settings
            new Settings();
            Settings.Speed = int.Parse(lbSpeed.Text);
            //Game speed and timer start
            gameTimer.Interval = 200 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            lbSpeed.Text = Settings.Speed.ToString();

            //Start new game
            StartGame();
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerSnake;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.SnakeStyle;
            headColor = Color.DimGray;
            bodyColor = Color.Silver;
            pbCanvas.BackColor = ThemeInfo.BackColor;
        }

        /// <summary>
        /// Start new game
        /// </summary>
        private void StartGame()
        {
            lbGameOver.Visible = false;
            //Default settings
            new Settings();
            Settings.Speed = int.Parse(lbSpeed.Text);
            //new player object
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lbScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        /// <summary>
        /// Place random food in game
        /// </summary>
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }

        /// <summary>
        /// Updates the screen
        /// </summary>
        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for game over
            if (Settings.GameOver == true)
            {
                //Check if enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Settings.GameOver == false)
            {
                //Set color of snake
                SolidBrush snakeColor;

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    //Draw head
                    if (i == 0)
                    {
                        snakeColor = new SolidBrush(headColor);
                    }
                    else
                    {
                        snakeColor = new SolidBrush(bodyColor);
                    }

                    //Draw Snake
                    canvas.FillEllipse(snakeColor,
                        new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));

                    //Draw Food
                    canvas.FillEllipse(new SolidBrush(foodColor), new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "GAME OVER! \nDein Punktestand ist: " + Settings.Score + "\nDrück ENTER um erneut zu spielen oder ESC um zu beenden.";
                lbGameOver.Text = gameOver;
                lbGameOver.Visible = true;
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move Head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction Down:
                            Snake[i].Y++;
                            break;

                    }

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with borders
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }

                    //Detect collision with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collission with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form_snake_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                if (Settings.Speed > 1)
                {
                    Settings.Speed--;
                    gameTimer.Interval = 200 / Settings.Speed;
                    lbSpeed.Text = Settings.Speed.ToString();
                }
            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                Settings.Speed++;
                gameTimer.Interval = 200 / Settings.Speed;
                lbSpeed.Text = Settings.Speed.ToString();
            }
        }

        private void Form_snake_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            //Add circle to body
            Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            //Update Score
            Settings.Score += Settings.Points;
            lbScore.Text = Settings.Score.ToString();

            GenerateFood();
        }
    }
}
