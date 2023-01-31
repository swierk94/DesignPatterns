using CreationalPatterns.FactoryPattern;
using CreationalPatterns.FluentBuilderPattern;

namespace CreationalPatterns
{
    internal class Program
    {
        internal static void Main()
        {
            var specificProduct = CreateProduct(ProductType.ProductC);

            Console.WriteLine($"Product created by factory {specificProduct}\n");

            var complexProduct = CreateComplexProduct();

            Console.WriteLine($"" +
                $"Complex product created by builder, creation steps: \n" +
                $"{complexProduct.FirstCreationStep} \n" +
                $"{complexProduct.SecondCreationStep} \n" +
                $"{complexProduct.LastCreationStep}" );
        }

        internal static string CreateProduct(ProductType product)
        {
            var factory = new Factory();
            var createdProduct = factory.GetProduct(product);
            return createdProduct.CreateProduct();
        }
        
        internal static FluentBuilderPattern.Product CreateComplexProduct() 
        {
            var fluentBuilder = new FluentBuilder();
            var directorBuilder = new DirectorBuilder(fluentBuilder);
            
            directorBuilder.CreateCompleteProduct();
            return fluentBuilder.GetProduct();
        }
    }
}