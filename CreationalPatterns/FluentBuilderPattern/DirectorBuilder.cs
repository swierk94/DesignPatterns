namespace CreationalPatterns.FluentBuilderPattern
{
    internal class DirectorBuilder
    {
        private readonly IFluentBuilder _fluentBuilder;

        public DirectorBuilder(IFluentBuilder fluentBuilder)
        {
            _fluentBuilder = fluentBuilder;
        }

        internal void CreateCompleteProduct() 
        {
            _fluentBuilder.DoFirstStep();
            _fluentBuilder.DoSecondStep();
            _fluentBuilder.DoLastStep();
        }
    }
}
