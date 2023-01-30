using StructuralPatterns.FacadePattern;

namespace StructuralPatterns
{
    internal class Program
    {
        internal static void Main()
        {
            ActionsFacade.
                DoActions().
                ForEach(action =>
                {
                    Console.WriteLine(action);
                });            
        }
    }
}