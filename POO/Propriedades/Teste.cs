using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {

        private string _nome;
        public string Sobrenome { get; } = "Barrilli";
        private int _idade;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { 
                if (value < 18)
                {
                    Console.WriteLine("Você é menor de idade, menor de 18 anos");
                } else
                {
                    _idade = value;
                }
            }
        }
    }
}
