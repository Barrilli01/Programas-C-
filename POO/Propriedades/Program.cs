using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();

            Console.WriteLine("Digite seu primeiro nome");
            t.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            t.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(" tem " + t.Idade + " anos");

            Console.ReadKey();
        }
    }
}
