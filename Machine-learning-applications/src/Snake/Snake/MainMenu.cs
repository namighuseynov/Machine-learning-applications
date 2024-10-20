using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OpenTrainingConfigurator(object sender, EventArgs e)
        {
            Form1.Instance.TrainingConfiguratorUI.Visible = true;
            Visible = false;
        }
    }
}
