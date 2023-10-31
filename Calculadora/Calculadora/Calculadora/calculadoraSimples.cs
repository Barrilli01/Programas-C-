using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class calculadoraSimples
    {
        static void Main(string[] args)
        {
            calculadoraSimples calc = new calculadoraSimples();
            int x, y;

            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo número");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Tecle ' + ' para soma, ' - ' para subtração, ' * ' para multiplicação e ' / ' para divisão");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine(calc.soma(x, y));
                    break;
                case "-":
                    Console.WriteLine(calc.subtracao(x, y));
                    break;
                case "*":
                    Console.WriteLine(calc.multiplicacao(x, y));
                    break;
                case "/":
                    Console.WriteLine(calc.divisao(x, y));
                    break;
                default:

                    Console.WriteLine(operacao + " não corresponde a uma das operações");
                    break;
            }


            Console.ReadKey();
        }

        public int soma(int x, int y)
        {
            int resultado = x + y;

            return resultado;
        }

        public int subtracao(int x, int y)
        {
            int resultado = x - y;

            return resultado;
        }
        public int multiplicacao(int x, int y)
        {
            int resultado = x * y;

            return resultado;
        }

        public int divisao(int x, int y)
        {
            int resultado = x / y;

            return resultado;
        }
    }

}
