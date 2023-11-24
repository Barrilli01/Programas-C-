using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estática
            /*
            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine("Valor 1: " + valor1);
            
            Console.WriteLine("Valor 2: " + valor2);
            */
            #endregion

            Pessoa.maioridade = 21;
            Pessoa p1 = new Pessoa();

            p1.nome = "Gabriel";
            p1.idade = Pessoa.CalcularIdade(2004);

            p1.Apresentar(p1.nome);
            Console.WriteLine(" e tenho " + p1.idade + " anos");

            Console.ReadKey();
        }
    }
}
