using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameMenu : UserControl
    {
        private TicTacToeProcess _gameProcess;
        private CoolAgent _agent;
        private int _selectedCellId = 0;
        public GameMenu()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            if (_agent == null) _agent = new CoolAgent("model1", true);
            

        }

        private void SelectCell(object sender, EventArgs e)
        {
            if (_gameProcess == null) _gameProcess = new TicTacToeProcess(Form1.Instance);
            _gameProcess.Begin();
            var cell = sender as Button;
            int cellId = Convert.ToInt32(cell.Tag);
            _gameProcess.SelectCell(cellId);

            if (_gameProcess.CheckGameState())
            {
                _gameProcess.End();
            }
            else
            {
                int action = _agent.TakeAction(_gameProcess);
                _gameProcess.SelectCell(action);
                if (_gameProcess.CheckGameState())
                {
                    _gameProcess.End();
                }
            }
        }
    }
}
