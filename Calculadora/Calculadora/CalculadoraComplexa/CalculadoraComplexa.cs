
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComplexa
{
    internal class CalculadoraComplexa
    {
        static void Main(string[] args)
        {
            Operacoes operacoes = new Operacoes();
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

            Console.WriteLine("");
            switch (operacao)
            {
                case "+":
                    Console.WriteLine(operacoes.soma(x, y));
                    break;
                case "-":
                    Console.WriteLine(operacoes.subtracao(x, y));
                    break;
                case "*":
                    Console.WriteLine(operacoes.multiplicacao(x, y));
                    break;
                case "/":
                    Console.WriteLine(operacoes.divisao(x, y));
                    break;
                default:

                    Console.WriteLine(operacao + " não corresponde a uma das operações");
                    break;
            }


            Console.ReadKey();
        }
    }
}
