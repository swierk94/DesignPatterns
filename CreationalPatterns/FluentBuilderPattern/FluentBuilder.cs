namespace CreationalPatterns.FluentBuilderPattern
{
    internal class FluentBuilder : IFluentBuilder
    {
        private Product _product;

        public FluentBuilder()
        {
            Reset();
        }

        public IFluentBuilder DoFirstStep()
        {
            _product.FirstCreationStep = "First step was done";
            return this;
        }

        public IFluentBuilder DoLastStep()
        {
            _product.LastCreationStep = "Last step was done";
            return this;
        }

        public IFluentBuilder DoSecondStep()
        {
            _product.SecondCreationStep = "Second step was done";
            return this;
        }

        public Product GetProduct()
        {
            Product completeProduct = _product;
            Reset();

            return completeProduct;
        }

        public void Reset ()
        {
            _product = new Product();
        }
    }
}
