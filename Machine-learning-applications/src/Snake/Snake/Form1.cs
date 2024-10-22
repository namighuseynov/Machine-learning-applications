using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        public MainMenu MainMenuUI
        {
            get { return mainMenu1; }
        }

        public TrainingConfigurator TrainingConfiguratorUI
        {
            get
            {
                return trainingConfigurator1;
            }
        }

        public LearningProcess LearningProcessUI
        {
            get
            {
                return learningProcess1;
            }
        }
    }
}
