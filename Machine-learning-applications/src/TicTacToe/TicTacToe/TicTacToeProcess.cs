using System;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// The tic tac toe game process
    /// </summary>
    public sealed class TicTacToeProcess : IProcess
    {
        #region Events
        /// <summary>
        /// Calls when cell was selected
        /// </summary>
        public event EventHandler<int> OnCellWasSelected;
        #endregion

        #region Constructors
        /// <summary>
        /// The main constructor
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public TicTacToeProcess(Form1 instance)
        {
            _myTurn = true;
            _cells = new char[9];
            _instance = instance;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Define turn
        /// </summary>
        private bool _myTurn = true;
        /// <summary>
        /// Table cells
        /// </summary>
        private char[] _cells;
        /// <summary>
        /// Instance of the form
        /// </summary>
        private Form1 _instance;
        private char _sign;
        #endregion

        #region Methods
        /// <summary>
        /// Start the process
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Begin()
        {
            for (var i = 0; i < _cells.Length; i++)
            {
                _cells[i] = ' ';
            }
            _myTurn = true;
        }
        /// <summary>
        /// End the process
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>

        public void End()
        {
            _instance.EndGame();
        }
        #endregion

        private bool CheckGameState()
        {
            if ((_cells[0] == _cells[1]) && (_cells[1] == _cells[2]) && (_cells[2] != ' ')) return true;
            else if ((_cells[3] == _cells[4]) && (_cells[4] == _cells[5]) && (_cells[5] != ' ')) return true;
            else if ((_cells[6] == _cells[7]) && (_cells[7] == _cells[8]) && (_cells[8] != ' ')) return true;
            else if ((_cells[0] == _cells[3]) && (_cells[3] == _cells[6]) && (_cells[6] != ' ')) return true;
            else if ((_cells[1] == _cells[4]) && (_cells[4] == _cells[7]) && (_cells[7] != ' ')) return true;
            else if ((_cells[2] == _cells[5]) && (_cells[5] == _cells[8]) && (_cells[8] != ' ')) return true;
            else if ((_cells[0] == _cells[4]) && (_cells[4] == _cells[8]) && (_cells[8] != ' ')) return true;
            else if ((_cells[2] == _cells[4]) && (_cells[4] == _cells[6]) && (_cells[6] != ' ')) return true;
            else return false;
        }

        public void SelectCell(int id)
        {
            if (_cells[id] == ' ')
            {
                PrepareSign();
                string cellName = "cell" + (id + 1).ToString();
                Control cell = _instance.Controls.Find(cellName, true)[0];
                cell.Text = _sign.ToString();
                _cells[id] = _sign;

                if (CheckGameState())
                {
                    End();
                }
                else
                {
                    _myTurn = !_myTurn;
                }

                
            }
            else
            {
                MessageBox.Show("this cell is filled!");
            }
            
        }

        public void PrepareSign()
        {
            if (_myTurn) { _sign = 'x'; }
            else { _sign = 'o'; }
        }
    }
}