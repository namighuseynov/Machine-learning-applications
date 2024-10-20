namespace Snake
{
    /// <summary>
    /// Training configuration used for training the model
    /// </summary>
    public class TrainingConfiguration
    {
        #region Fields
        private readonly double _learningRate;
        private readonly double _maxIterations;
        private readonly double _epsilon;
        private readonly double _gamma;
        private readonly bool _continueTraining;
        #endregion

        #region Constructors 
        public TrainingConfiguration(
            double learningRate,
            double episodes,
            double epsilon,
            double gamma,
            bool continueTraining)
        {
            _learningRate = learningRate;
            _maxIterations = episodes;
            _epsilon = epsilon;
            _gamma = gamma;
            _continueTraining = continueTraining;
        }
        #endregion

        #region Fields
        public double LearningRate { get { return _learningRate; } }
        public double MaxIterations { get { return _maxIterations; } }
        public double ExplorationRate { get { return _epsilon; } }
        public double DiscountFactor { get { return _gamma; } }
        public bool ContinueTraining { get { return _continueTraining; } }
        #endregion
    }
}
