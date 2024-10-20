using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public bool LearningMode = false;
        int selectedCellId = 0;
        private TicTacToeProcess gameProcess;
        private CoolAgent agent;
        private int episodes = 100000;
        private int currentEpisode = 0;
        public static Form1 Instance;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Move()
        {
            while (currentEpisode < episodes)
            {
                int cellId = agent.GetRandomAction(gameProcess);
                gameProcess.SelectCell(cellId);
                int winner = -100;
                int reward = -1;
                string state = string.Empty;
                if (gameProcess.CheckGameState())
                {
                    winner = gameProcess.Winner;
                    state = gameProcess.State;

                    if (winner == 0) { reward = 0; }
                    else if (winner == 1) { reward = 100; }
                    else if (winner == -1) { reward = -100; }
                    agent.UpdateQTable(gameProcess, reward);
                }
                else
                {
                    int action = agent.TakeAction(gameProcess);
                    gameProcess.SelectCell(action);
                    agent.UpdateQTable(gameProcess, reward);
                    if (gameProcess.CheckGameState())
                    {
                        winner = gameProcess.Winner;
                        state = gameProcess.State;

                        if (winner == 0) { reward = 0; }
                        else if (winner == 1) { reward = 100; }
                        else if (winner == -1) { reward = -100; }
                        agent.UpdateQTable(gameProcess, reward);
                    }
                }
            }
            agent.SaveBrain();
            gameProcess.End();
        }

        private void Initialize()
        {
            agent = new CoolAgent("model1", !LearningMode);
        }

        private void SelectedCellHandler(object sender, EventArgs e)
        {
            var cell = sender as Button;
            int cellId = Convert.ToInt32(cell.Tag);
            gameProcess.SelectCell(cellId);
            if (gameProcess.CheckGameState())
            {
                gameProcess.End();
            }
            else
            {
                int action = agent.TakeAction(gameProcess);
                gameProcess.SelectCell(action);
                if (gameProcess.CheckGameState())
                {
                    gameProcess.End();
                }
            }

        }

        public void StartGame(object sender, EventArgs e)
        {
            button9.Visible = false;
            BeginGame();

            if (LearningMode)
            {
                //timer = new Timer();
                //timer.Tick += new EventHandler(Move);
                //timer.Interval = 5000;
                //timer.Start();

                Move();
            }

        }

        private void BeginGame()
        {
            label1.Text = "Episode: " + currentEpisode.ToString();
            if (gameProcess == null)
            {
                gameProcess = new TicTacToeProcess(this);
            }
            gameProcess.Begin();
            if (agent == null) Initialize();
            tableLayoutPanel1.Enabled = true;
        }

        public void EndGame()
        {
            foreach (Button cell in tableLayoutPanel1.Controls)
            {
                cell.Text = string.Empty;
            }
            if (LearningMode)
            {
                currentEpisode++;
                if (currentEpisode < episodes)
                {
                    BeginGame();
                }
            }
        }

        public MainMenu MainMenuInterface
        {
            get
            {
                return mainMenu1;
            }
        }
    }
}
