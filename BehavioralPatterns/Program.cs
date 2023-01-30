using BehavioralPatterns.StrategyPattern;
using BehavioralPatterns.StrategyPattern.SpecificStrategies;

namespace BehavioralPatterns
{
    internal class Program
    {
        internal static void Main()
        {
            Console.WriteLine(GetSpecificStrategyResult(new StrategyA()));
        }

        internal static string GetSpecificStrategyResult(ISpecificStrategy specificStrategy)
        {
            var strategy = new Strategy(specificStrategy);
            var result = strategy.GetSpecificStrategyResult();
            return result;
        }
    }    
}