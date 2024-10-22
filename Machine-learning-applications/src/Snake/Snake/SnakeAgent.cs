using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Snake
{
    public class SnakeAgent
    {
        private TrainingConfiguration _configuration;
        private Random _random;
        private Dictionary<(string, int), double> _qTable;
        public SnakeAgent(TrainingConfiguration config)
        {
            _configuration = config;
            _qTable = new Dictionary<(string, int), double>();
            _random = new Random();
        }

        public double GetQValue(string state, int action)
        {
            if (_qTable.ContainsKey((state, action)))
            {
                return _qTable[(state, action)];
            }
            return 0.0;
        }

        public void SetQValue(string state, int action, double value)
        {
            _qTable[(state, action)] = value;
        }

        public int TakeAction(string state, List<int> actions)
        {
            if (_random.NextDouble() < _configuration.ExplorationRate)
            {
                return actions[_random.Next(actions.Count)];
            }
            int bestAction = actions[0];
            double bestValue = GetQValue(state, bestAction);
            foreach (var action in actions)
            {
                double qValue  = GetQValue(state, action);
                if (qValue > bestValue)
                {
                    bestValue  = qValue;
                    bestAction = action;
                }
            }
            return bestAction;
        }

        public void UpdateQValue(string state, int action, string nextState, List<int> nextActions, double reward)
        {
            double qValue = GetQValue(state, action);
            double maxNextQ = GetQValue(nextState, nextActions[0]);

            foreach (var nextAction in nextActions)
            {
                double nextQ = GetQValue(nextState, nextAction);
                if (nextQ > maxNextQ)
                {
                    maxNextQ = nextQ;
                }
            }
            double newQValue = qValue + _configuration.LearningRate * (reward + _configuration.DiscountFactor * maxNextQ - qValue);
            SetQValue(state, action, newQValue);
        }

        public void SaveBrain(string path)
        {
            try
            {
                var serializedQTable = JsonConvert.SerializeObject(_qTable, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, serializedQTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Q-table: " + ex.Message);
            }
        }

        public void LoadModel(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var serializedQTable = File.ReadAllText(filePath);
                    _qTable = JsonConvert.DeserializeObject<Dictionary<(string, int), double>>(serializedQTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading Q-table: " + ex.Message);
            }
        }
    }
}
