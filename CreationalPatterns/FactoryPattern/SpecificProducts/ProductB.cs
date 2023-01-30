namespace CreationalPatterns.FactoryPattern.SpecificProducts
{
    internal class ProductB : Product
    {
        public override string CreateProduct()
            => $"Product B created";
    }
}