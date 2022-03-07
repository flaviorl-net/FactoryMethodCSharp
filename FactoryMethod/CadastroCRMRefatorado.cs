using System;

namespace FactoryMethod.CadastroCRMRefatorado
{
    public class Cliente
    {
        static Cliente()
        {
            var suspect = Funil.Suspect;
            var funilFactory = new FunilFactory();

            funilFactory.ObterFunil(suspect)
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
        IFunil ObterFunil(Funil funil);
    }

    public class FunilFactory : IFunilFactory
    {
        public IFunil ObterFunil(Funil funil)
        {
            return funil switch
            {
                Funil.Suspect => new Suspect(),
                Funil.Prospect => new Prospect(),
                _ => throw new NotImplementedException(),
            };
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
