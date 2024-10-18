using System;

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
        public TicTacToeProcess()
        {
            _myTurn = true;
            _cells = new char[9];
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
        #endregion

        #region
        /// <summary>
        /// Start the process
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Begin()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// End the process
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>

        public void End()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        private bool CheckGameState()
        {
            throw new System.NotImplementedException();
        }
    }
}