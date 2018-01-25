using System;
namespace AbstractFactoryPattern
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public ConcreteFactory2()
        {
        }

        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
