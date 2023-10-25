using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            m.MostraNome("Gabriel");
            Console.WriteLine(", a soma dos números digitados é igual a: " + m.Soma(10, 20));

            //m.Cumprimentar1("Gabriel este é o método simples", 16);

            m.Cumprimentar2("João este é o método composto", 16);

            Console.ReadKey();
        }
    }
}
