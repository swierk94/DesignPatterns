using CreationalPatterns.FactoryPattern.SpecificProducts;

namespace CreationalPatterns.FactoryPattern
{
    internal class Factory
    {    
        public Product GetProduct(ProductType productType)
            => productType switch
            {
                ProductType.ProductA => new ProductA(),
                ProductType.ProductB => new ProductB(),
                ProductType.ProductC => new ProductC(),
                _ => throw new ArgumentException("Provide correct product type"),
            };
    }
}
