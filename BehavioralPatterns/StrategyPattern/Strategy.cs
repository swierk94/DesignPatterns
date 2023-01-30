using BehavioralPatterns.StrategyPattern.SpecificStrategies;

namespace BehavioralPatterns.StrategyPattern
{
    internal class Strategy 
    {
        private ISpecificStrategy _specificStrategy;

        internal Strategy(ISpecificStrategy specificStrategy) 
        {
            _specificStrategy = specificStrategy;
        }

        public string GetSpecificStrategyResult()
            => _specificStrategy.GetSpecificStrategyResult();
    }
}