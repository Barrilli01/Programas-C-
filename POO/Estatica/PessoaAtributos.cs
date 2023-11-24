using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatica
{
    partial class Pessoa
    {
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
