using CreationalPatterns.FactoryPattern;

namespace CreationalPatterns
{
    internal class Program
    {
        internal static void Main()
        {
            Console.WriteLine(CreateProduct(ProductType.ProductC));
        }

        internal static string CreateProduct(ProductType product)
        {
            var factory = new Factory();
            var createdProduct = factory.GetProduct(product);
            return createdProduct.CreateProduct();
        }
    }
}