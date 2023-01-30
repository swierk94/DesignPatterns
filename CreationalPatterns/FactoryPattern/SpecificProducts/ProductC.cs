namespace CreationalPatterns.FactoryPattern.SpecificProducts
{
    internal class ProductC : Product
    {
        public override string CreateProduct()
            => $"Product C created";
    }
}