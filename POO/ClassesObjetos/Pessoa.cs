using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        //Atributos de uma pessoa

        public string nome;
        public string sobrenome;
        public int anoNascimento;

        public void Apresentar()
        {
            Console.WriteLine("" + nome + " " + sobrenome + " nasceu no ano de " + anoNascimento);
        }
    }

}
