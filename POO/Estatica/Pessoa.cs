using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatica
{
    internal class Pessoa
    {
        public static int maioridade = 18;

        public string nome;
        public int idade;

        public void Apresentar(string nome)
        {
            Console.Write("Olá, meu nome é " + nome);
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
