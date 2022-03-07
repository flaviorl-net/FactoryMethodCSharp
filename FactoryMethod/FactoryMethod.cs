using System;
using System.Collections.Generic;

namespace FactoryMethod.GOF
{
    public class Cliente
    {
        public Cliente()
        {
            var creators = new List<ICreator>() {
                new ConcreteCreatorA(),
                new ConcreteCreatorB()
            };

            Console.WriteLine("{0}", creators[0].FactoryMethod().Tipo());
            Console.WriteLine("{0}", creators[1].FactoryMethod().Tipo());

            Console.ReadKey();
        }
    }

    public interface IProduct
    {
        string Tipo();
    }

    public class ConcreteProductA : IProduct
    {
        public string Tipo() => "ConcreteProductA";
    }

    public class ConcreteProductB : IProduct
    {
        public string Tipo() => "ConcreteProductB";
    }

    public interface ICreator
    {
        IProduct FactoryMethod();
    }

    public class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
