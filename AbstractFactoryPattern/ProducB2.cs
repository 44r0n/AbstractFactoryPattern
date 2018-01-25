using System;
namespace AbstractFactoryPattern
{
    public class ProductB2 : AbstractProductB
    {
        public ProductB2()
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Execute ProductB2");
        }
    }
}
