using System;
namespace AbstractFactoryPattern
{
    public class ProductA2 : AbstractProductA
    {
        public ProductA2()
        {
        }

        public override void Action()
        {
            Console.WriteLine("Action ProductA2");
        }
    }
}
