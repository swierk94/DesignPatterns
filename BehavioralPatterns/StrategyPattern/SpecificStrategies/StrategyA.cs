namespace BehavioralPatterns.StrategyPattern.SpecificStrategies
{
    internal class StrategyA : ISpecificStrategy
    {
        public string GetSpecificStrategyResult()
            => "Strategy A result";
    }
}