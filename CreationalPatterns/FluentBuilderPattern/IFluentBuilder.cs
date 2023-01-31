namespace CreationalPatterns.FluentBuilderPattern
{
    internal interface IFluentBuilder
    {
        IFluentBuilder DoFirstStep();
        IFluentBuilder DoSecondStep();
        IFluentBuilder DoLastStep();

        Product GetProduct();
    }
}