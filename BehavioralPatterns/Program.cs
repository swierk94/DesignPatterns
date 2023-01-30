using BehavioralPatterns.StrategyPattern;
using BehavioralPatterns.StrategyPattern.SpecificStrategies;

namespace BehavioralPatterns
{
    internal class Program
    {
        internal static void Main()
        {
            Console.WriteLine(Strategy(new StrategyA()));
        }

        internal static string Strategy(ISpecificStrategy specificStrategy)
        {
            var strategy = new Strategy(specificStrategy);
            var result = strategy.GetSpecificStrategyResult();
            return result;
        }
    }    
}