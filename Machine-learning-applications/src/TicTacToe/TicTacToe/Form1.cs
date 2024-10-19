using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int selectedCellId = 0;
        private TicTacToeProcess gameProcess;
        private CoolAgent agent;
        private int episodes = 5000;
        private int currentEpisode = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Move()
        {
            while (currentEpisode < episodes)
            {
                int cellId = agent.GetRandomAction(gameProcess);
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

                if (gameProcess.Winner == 1)
                {
                    agent.UpdateQTable(gameProcess, 1);
                }
                if (gameProcess.Winner == 0)
                {
                    agent.UpdateQTable(gameProcess, 0);
                }
                if (gameProcess.Winner == -1)
                {
                    agent.UpdateQTable(gameProcess, -1);
                }
            }
            agent.SaveBrain();
            gameProcess.End();
        }

        private void Initialize()
        {
            agent = new CoolAgent("model1");
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

            if (gameProcess.Winner == 1)
            {
                agent.UpdateQTable(gameProcess, 1);
            }
            if (gameProcess.Winner == 0)
            {
                agent.UpdateQTable(gameProcess, 0);
            }
            if (gameProcess.Winner == -1)
            {
                agent.UpdateQTable(gameProcess, -1);
            }
        }

        public void StartGame(object sender, EventArgs e)
        {
            button9.Visible = false;
            BeginGame();
            Move();
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
            //MessageBox.Show("winner is :" + gameProcess.Winner.ToString());

            currentEpisode++;
            if (currentEpisode < episodes)
            {
                BeginGame();
            }
        }
    }
}
