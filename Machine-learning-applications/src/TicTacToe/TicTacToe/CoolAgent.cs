using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace TicTacToe
{
    public class CoolAgent : Agent
    {
        private float _epsilon = 0.2f;
        private float _alpha = 0.1f;
        private float _gamma = 0.9f;
        private Dictionary<string, double[]> _qTable;
        private int _lastAction;
        private string _lastState;
        private string modelFilePath;

        public CoolAgent(string  name)
        {
            _epsilon = 0.2f;
            _alpha = 0.1f;
            _gamma = 0.9f;
            modelFilePath = "qlearning_" + name + ".json";
            if (!LoadBrain())
            {
                _qTable = new Dictionary<string, double[]>();
            }
        }

        public int TakeAction(TicTacToeProcess gameProcess)
        {
            string state = gameProcess.State;
            int desiredAction = -1;
            //Exploration or exploitation
            if (new Random().NextDouble() < _epsilon)
            {
                desiredAction = GetRandomAction(gameProcess);
            }
            else
            {
                if (!_qTable.ContainsKey(state))
                {
                    _qTable[state] = new double[9];
                }
                double[] qValues = _qTable[state];
                int[] availableActions = GetAvailableActions(gameProcess);

                double maxQValue = double.MinValue;
                int bestAction = -1;
                foreach (var action in availableActions)
                {
                    if (qValues[action] > maxQValue)
                    {
                        maxQValue = qValues[action];
                        bestAction = action;
                    }
                }
                _lastAction = bestAction;
                _lastState = state;
                desiredAction = bestAction;
            }
            return desiredAction;
        }

        public int[] GetAvailableActions(TicTacToeProcess game)
        {
            var state = game.State;
            var actions = new List<int>();
            for (var i = 0; i < state.Length; i++)
            {
                if (state[i] == ' ')
                {
                    actions.Add(i);
                }
            }
            return actions.ToArray();
        }

        public int GetRandomAction(TicTacToeProcess game)
        {
            var availableActions = GetAvailableActions(game);
            return availableActions[new Random().Next(availableActions.Length)];
        }

        public void UpdateQTable(TicTacToeProcess game, double reward)
        {
            string state = game.State;
            if (!_qTable.ContainsKey(state))
            {
                _qTable[state] = new double[9];
            }
            double[] qValues = _qTable[state];

            double maxQValue = qValues.Max();

            _qTable[_lastState][_lastAction] += _alpha * (reward + _gamma * maxQValue - _qTable[_lastState][_lastAction]);

        }

        public void SaveBrain()
        {
            using (StreamWriter writer = new StreamWriter(modelFilePath))
            {
                foreach (var entry in _qTable)
                {
                    string state = entry.Key;
                    double[] qValues = entry.Value;

                    string qValuesString = string.Join(",", qValues);
                    writer.WriteLine($"{state}:{qValuesString}");
                }
            }
        }

        public bool LoadBrain()
        {
            if (File.Exists(modelFilePath))
            {
                using (StreamReader reader = new StreamReader(modelFilePath))
                {
                    _qTable = new Dictionary<string, double[]>();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(':');
                        string state = parts[0];
                        double[] qValues = parts[1].Split(',').Select(double.Parse).ToArray();
                        _qTable[state] = qValues;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}