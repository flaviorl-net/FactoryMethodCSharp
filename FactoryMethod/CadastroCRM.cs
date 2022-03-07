using System;

namespace FactoryMethod.CadastroCRM
{
    public class Cliente
    {
        public Cliente()
        {
            string funil = "suspect";

            if (funil == "suspect")
            {
                Suspect suspect = new Suspect();
                suspect.CadastrarSuspect("James", "Hetfield", "123456789", "Downey, Califórnia, EUA");
            }

            if (funil == "prospect")
            {
                Prospect prospect = new Prospect();
                prospect.CadastrarProspect("James", "Hetfield", "123456789", "Downey, Califórnia, EUA");
            }

            Console.ReadKey();
        }
    }

    public class Suspect
    {
        public void CadastrarSuspect(string nome, string sobrenome, string celular, string endereco)
        {
            //Cadastra no banco de dados
            Console.WriteLine("Suspect {0} Cadastrado.", nome);
        }
    }

    public class Prospect
    {
        public void CadastrarProspect(string nome, string sobrenome, string celular, string endereco)
        {
            //Cadastra no banco de dados
            Console.WriteLine("Suspect {0} Cadastrado.", nome);
        }
    }

}
