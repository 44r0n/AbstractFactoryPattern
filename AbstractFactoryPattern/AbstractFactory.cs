using System;
namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public AbstractFactory()
        {
        }

        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
