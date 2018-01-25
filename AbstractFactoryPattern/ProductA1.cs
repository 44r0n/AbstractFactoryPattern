using System;
namespace AbstractFactoryPattern
{
    public class ProductA1 : AbstractProductA
    {
        public ProductA1()
        {
        }

        public override void Action()
        {
            Console.WriteLine("Action ProductA1");
        }
    }
}
