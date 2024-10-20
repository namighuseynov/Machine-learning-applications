using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake
{
    public partial class TrainingConfigurator : UserControl
    {
        public TrainingConfigurator()
        {
            InitializeComponent();
        }

        private void OpenMainMenu(object sender, EventArgs e)
        {
            Form1.Instance.MainMenuUI.Visible = true;
            Visible = false;
        }

        private void TrainTheModel(object sender, EventArgs e)
        {
            double episodes = double.Parse(episodeLabel.Text);
            double alpha = double.Parse(learningRateLabel.Text);
            double gamma = double.Parse(gammaLabel.Text);
            double epsilon = double.Parse(epsilonLabel.Text);
            bool continueTraining = continueTrainingCheckbox.Checked;

            TrainingConfiguration config = new TrainingConfiguration(
                alpha,
                episodes,
                epsilon,
                gamma,
                continueTraining
            );
            
            Form1.Instance.LearningProcessUI.Visible = true;
            Visible = false;

        }
    }
}
