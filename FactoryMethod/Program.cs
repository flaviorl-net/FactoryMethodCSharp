using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            var funilFactory = new FunilFactory();

            //Cadastra James como um Suspect
            funilFactory.ObterFunil<Suspect>()
                .Cadastrar(new FunilModel() { Nome = "James" });

            //Cadastra James como um Prospect
            funilFactory.ObterFunil<Prospect>()
                .Cadastrar(new FunilModel() { Nome = "James" });

            Console.ReadLine();
        }
    }

    public enum Funil
    {
        Suspect,
        Prospect
    }

    public class FunilModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
    }

    public interface IFunilFactory
    {
        IFunil ObterFunil<T>();
    }

    public class FunilFactory : IFunilFactory
    {
        public IFunil ObterFunil<T>()
        {
            return (IFunil)Activator.CreateInstance(typeof(T));
        }
    }

    public interface IFunil
    {
        void Cadastrar(FunilModel funilModel);
    }

    public class Suspect : IFunil
    {
        public void Cadastrar(FunilModel funilModel)
        {
            //Cadastra no banco de dados
            Console.WriteLine("Suspect {0} Cadastrado.", funilModel.Nome);
        }
    }

    public class Prospect : IFunil
    {
        public void Cadastrar(FunilModel funilModel)
        {
            //Cadastra no banco de dados
            Console.WriteLine("Prospect {0} Cadastrado.", funilModel.Nome);
        }
    }
}