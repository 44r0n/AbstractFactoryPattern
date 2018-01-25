using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory1();
            AbstractFactory factory2 = new ConcreteFactory2();

            AbstractProductA productA = factory.CreateProductA();
            productA.Action();
            AbstractProductB productB = factory.CreateProductB();
            productB.Execute();

            productA = factory2.CreateProductA();
            productA.Action();
            productB = factory2.CreateProductB();
            productB.Execute();
        }
    }
}
