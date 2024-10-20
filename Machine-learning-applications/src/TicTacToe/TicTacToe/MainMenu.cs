using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OpenTrainInterface(object sender, EventArgs e)
        {
            Form1.Instance.LearningMode = true;
            Visible = false;
            Enabled = false;
        }

        private void OpenGameMenu(object sender, EventArgs e)
        {
            Form1.Instance.LearningMode = false;
            Visible = false;
            Enabled = false;
            
        }
    }
}
