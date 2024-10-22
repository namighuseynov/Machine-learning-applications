using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class LearningProcess : UserControl
    {
        private SnakeObject _snake;
        private SnakeAgent _snakeAgent;
        private Food _food;
        private Timer _timer;
        private int segmentSize = 20;
        private int limitX = 22;
        private int limitY = 24;
        
        private TrainingConfiguration _trainingConfiguration;
        private int currentEpisode = 0;

        public LearningProcess()
        {
            InitializeComponent();
            _snake = new SnakeObject();
            _food = new Food(limitX, limitY);
            
            DoubleBuffered = true;
            _timer = new Timer();
            _timer.Interval = 1;
            _timer.Tick += Timer_Tick;
        }

        public void Set(TrainingConfiguration config)
        {
            _trainingConfiguration = config;
            _snakeAgent = new SnakeAgent(_trainingConfiguration);
            PaintStats();
        }

        private void PaintStats()
        {
            label1.Text = "Episode: " + currentEpisode.ToString();
            label2.Text = "Alpha: " + _trainingConfiguration.LearningRate.ToString();
            label3.Text = "Gamma: " + _trainingConfiguration.DiscountFactor.ToString();
            label4.Text = "Epsilon: " + _trainingConfiguration.ExplorationRate.ToString();
        }

        private void PerformAgentStep()
        {
            string state = GetState();
            List<int> actions = new List<int>() { 0, 1, 2, 3 };

            int action = _snakeAgent.TakeAction(state, actions);

            // Применяем выбранное действие
            if (action == (int)Direction.Up && _snake.CurrentDirection != Direction.Down)
                _snake.CurrentDirection = Direction.Up;
            else if (action == (int)Direction.Down && _snake.CurrentDirection != Direction.Up)
                _snake.CurrentDirection = Direction.Down;
            else if (action == (int)Direction.Left && _snake.CurrentDirection != Direction.Right)
                _snake.CurrentDirection = Direction.Left;
            else if (action == (int)Direction.Right && _snake.CurrentDirection != Direction.Left)
                _snake.CurrentDirection = Direction.Right;

            _snake.Move();

            double reward = 0.0;
            if (_snake.Body[0] == _food.Position)
            {
                _snake.Grow();
                _food.Generate(limitX, limitY);
                reward = 10.0; 
            }
            else if (IsCollision())
            {
                reward = -10.0; // Punish
                _timer.Stop();

                if (currentEpisode < _trainingConfiguration.MaxIterations)
                {
                    currentEpisode++;
                    NextEpisode();
                    PaintStats();
                }
                else
                {
                    //Need to handle this block
                    _snakeAgent.SaveBrain("snakeModel.json");
                }
            }
            string nextState = GetState();
            _snakeAgent.UpdateQValue(state, action, nextState, actions, reward);

            Invalidate(); // Перерисовка формы
        }

        private void StartEpisode()
        {
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PerformAgentStep();
            //_snake.Move();

            //if (_snake.Body[0] == _food.Position)
            //{
            //    _snake.Grow();
            //    _food.Generate(limitX, limitY);
            //}


            //if (IsCollision())
            //{
            //    _timer.Stop();

            //    if (currentEpisode < _trainingConfiguration.MaxIterations)
            //    {
            //        currentEpisode++;
            //        NextEpisode();
            //        PaintStats();
            //    }
            //    else
            //    {

            //    }

            //}

            //Invalidate(); 
        }

        private bool IsCollision()
        {
            Point head = _snake.Body[0];
            //MessageBox.Show(head.Y.ToString());
            // Столкновение с границами формы
            if (head.X < 0 || head.Y < 0 || head.X  >= limitX || head.Y >= limitY)
                return true;
            
            // Столкновение с телом змейки
            for (int i = 1; i < _snake.Body.Count; i++)
            {
                if (head == _snake.Body[i])
                    return true;
            }

            return false;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Отрисовка змейки
            foreach (Point segment in _snake.Body)
            {
                g.FillRectangle(Brushes.Green, new Rectangle(segment.X * segmentSize, segment.Y * segmentSize, segmentSize, segmentSize));
            }

            // Отрисовка еды
            g.FillRectangle(Brushes.Red, new Rectangle(_food.Position.X * segmentSize, _food.Position.Y * segmentSize, segmentSize, segmentSize));

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (_snake.CurrentDirection != Direction.Down)
                        _snake.CurrentDirection = Direction.Up;
                    break;
                case Keys.S:
                    if (_snake.CurrentDirection != Direction.Up)
                        _snake.CurrentDirection = Direction.Down;
                    break;
                case Keys.A:
                    if (_snake.CurrentDirection != Direction.Right)
                        _snake.CurrentDirection = Direction.Left;
                    break;
                case Keys.D:
                    if (_snake.CurrentDirection != Direction.Left)
                        _snake.CurrentDirection = Direction.Right;
                    break;
            }
        }

        private void NextEpisode()
        {
            _snake = new SnakeObject();
            _food = new Food(limitX, limitY);
            _timer.Start();
            Invalidate();
        }

        private void LearningProcess_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                StartEpisode();
            }
        }

        private string GetState()
        {
            Point head = _snake.Body[0];
            Point foodPosition = _food.Position;

            // Формируем строку состояния
            return $"{head.X},{head.Y},{foodPosition.X},{foodPosition.Y}";
        }
    }
}
