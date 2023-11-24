using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acesso acesso = new Acesso();

            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();
            Console.WriteLine();

            if (acesso.Login(senha))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }

            Console.ReadKey();
        }
    }
}
