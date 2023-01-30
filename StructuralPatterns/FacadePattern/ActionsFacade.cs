using StructuralPatterns.FacadePattern.FacadeActions;

namespace StructuralPatterns.FacadePattern
{
    internal class ActionsFacade
    {
        public static List<string> DoActions()
        => new()
            {
                FacadeActionA.DoActionA(),
                FacadeActionB.DoActionB(),
                FacadeActionC.DoActionC(),
                "All actions done correctly"
            };
    }
}