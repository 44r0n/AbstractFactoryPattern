using System;
namespace AbstractFactoryPattern
{
    public class ProductB1 : AbstractProductB
    {
        public ProductB1()
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Execute Product B1");
        }
    }
}
