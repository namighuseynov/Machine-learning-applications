using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int selectedCellId = 0;
        private TicTacToeProcess gameProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectedCellHandler(object sender, EventArgs e)
        {
            var cell = sender as Button;
            int cellId = Convert.ToInt32(cell.Tag);
            gameProcess.SelectCell(cellId);
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (gameProcess == null)
            {
                gameProcess = new TicTacToeProcess(this);
            }
            gameProcess.Begin();
            tableLayoutPanel1.Enabled = true;
        }

        public void EndGame()
        {
            foreach (Button cell in tableLayoutPanel1.Controls)
            {
                cell.Text = string.Empty;
            }
            MessageBox.Show("You win!");
        }
    }
}
