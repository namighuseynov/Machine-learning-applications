using System;
using System.Linq;
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
            _state = new char[9];
            _instance = instance;
            _winner = -100;
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
        private char[] _state;
        /// <summary>
        /// Instance of the form
        /// </summary>
        private Form1 _instance;
        private char _sign;
        private int _winner = int.MinValue;
        private bool _gameIsFinished = false;
        #endregion

        #region Methods
        /// <summary>
        /// Start the process
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Begin()
        {
            for (var i = 0; i < _state.Length; i++)
            {
                _state[i] = 'z';
            }
            _myTurn = true;
            _gameIsFinished = false;
            _winner = -100;
        }
        /// <summary>
        /// End the process
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>

        public void End()
        {
            _gameIsFinished = true;
            for (var i = 0; i < _state.Length; i++)
            {
                _state[i] = 'z';
            }
            _instance.EndGame();
        }
        /// <summary>
        /// Check is game finished
        /// </summary>
        /// <returns></returns>
        public bool CheckGameState()
        {
            if (!_state.Contains('z'))
            {
                _winner = 0;
                return true;
            }

            if ((_state[0] == _state[1]) && (_state[1] == _state[2]) && (_state[2] != 'z')) { _winner = _myTurn ? 1 : -1; return true; }
            else if ((_state[3] == _state[4]) && (_state[4] == _state[5]) && (_state[5] != 'z')) { _winner = _myTurn? 1 : -1; return true; }
            else if ((_state[6] == _state[7]) && (_state[7] == _state[8]) && (_state[8] != 'z')) { _winner = _myTurn? 1 : -1; return true; }
            else if ((_state[0] == _state[3]) && (_state[3] == _state[6]) && (_state[6] != 'z')) { _winner = _myTurn? 1 : -1; return true; }
            else if ((_state[1] == _state[4]) && (_state[4] == _state[7]) && (_state[7] != 'z')) { _winner = _myTurn? 1 : -1; return true; }
            else if ((_state[2] == _state[5]) && (_state[5] == _state[8]) && (_state[8] != 'z')) { _winner = _myTurn? 1 : -1; return true; }
            else if ((_state[0] == _state[4]) && (_state[4] == _state[8]) && (_state[8] != 'z')) { _winner = _myTurn? 1 : -1; return true; }
            else if ((_state[2] == _state[4]) && (_state[4] == _state[6]) && (_state[6] != 'z')) { _winner = _myTurn? 1 : -1; return true; }


            else return false;
        }
        /// <summary>
        /// Select certain cell
        /// </summary>
        /// <param name="id"></param>
        public void SelectCell(int id)
        {
            if (_state[id] == 'z')
            {
                PrepareSign();
                string cellName = "cell" + (id + 1).ToString();
                Control cell = _instance.Controls.Find(cellName, true)[0];
                cell.Text = _sign.ToString();
                _state[id] = _sign;
                _myTurn = !_myTurn;
            }
            else
            {
                MessageBox.Show("this cell is filled!");
            }
        }
        /// <summary>
        /// Prepare sign to play
        /// </summary>
        public void PrepareSign()
        {
            if (_myTurn) { _sign = 'x'; }
            else { _sign = 'o'; }
        }

        #endregion

        #region Properties
        /// <summary>
        /// The state of the game
        /// </summary>
        public string State
        {
            get
            {
                return new string(_state);
            }
        }
        public int Winner
        {
            get
            {
                return _winner;
            }
        }

        public bool Finished
        {
            get
            {
                return _gameIsFinished;
            }
        }

        #endregion


    }
}