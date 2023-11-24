using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    delegate void Operacao(int num1, int num2);

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();

            Operacao operacao = null;

            operacao += calculo.Somar;
            operacao += calculo.Subtrair;
            operacao += calculo.Multiplicar;
            operacao += calculo.Dividir;

            operacao(10, 5);
            
            Console.ReadKey();
        }
    }
}
