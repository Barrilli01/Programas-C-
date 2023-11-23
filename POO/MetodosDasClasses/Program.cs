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

            #region Testes
            /*m.MostraNome("Gabriel");
            Console.WriteLine(", a soma dos números digitados é igual a: " + m.Soma(10, 20));

            //m.Cumprimentar1("Gabriel este é o método simples", 16);

            m.Cumprimentar2("João este é o método composto", 16);
            */
            #endregion

            #region Sobrecargas
            // Sobrecargas de Métodos

            // De forma resumida, métodos podem ter mesmo nome,
            // desde que tenham parâmetros diferentes, ou em quantidade, ou em tipagem (string, int, double, etc)

            #endregion

            Console.ReadKey();
        }
    }
}
