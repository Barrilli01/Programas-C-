using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Início1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            int number1, number2;
            double temp, resultado;

            Console.WriteLine("Digite a temperatura inicial");
            Console.WriteLine("'1' para Celsius, '2' para Fahrenheit e '3' para Kelvin");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite para temperatura que deseja converter");
            Console.WriteLine("'1' para Celsius, '2' para Fahrenheit e '3' para Kelvin");
            number2 = int.Parse(Console.ReadLine());

            if (number1 == 1 && number2 == 2)
            {
                Console.WriteLine("Digite o valor da temperatura que deseja converter");
                temp = double.Parse(Console.ReadLine());

                resultado = (temp * 1.8) + 32;

                Console.WriteLine("O valor em Fahrenheit é: " + resultado);
            }
            else if (number1 == 1 && number2 == 3)
            {
                Console.WriteLine("Digite o valor da temperatura que deseja converter");
                temp = double.Parse(Console.ReadLine());

                resultado = temp + 273;

                Console.WriteLine("O valor em Kelvin: " + resultado);
            }
            else if (number1 == 2 && number2 == 3)
            {
                Console.WriteLine("Digite o valor da temperatura que deseja converter");
                temp = double.Parse(Console.ReadLine());

                resultado = ((temp - 32) / 1.8) + 273;

                Console.WriteLine("O valor em Kelvin: " + resultado);
            }
            else if (number1 == 2 && number2 == 1)
            {
                Console.WriteLine("Digite o valor da temperatura que deseja converter");
                temp = double.Parse(Console.ReadLine());

                resultado = (temp - 32) / 1.8;

                Console.WriteLine("O valor em Celsius: " + resultado);
            }
            else if (number1 == 3 && number2 == 1)
            {
                Console.WriteLine("Digite o valor da temperatura que deseja converter");
                temp = double.Parse(Console.ReadLine());

                resultado = temp - 273;

                Console.WriteLine("O valor em Celsius: " + resultado);
            }
            else if (number1 == 3 && number2 == 2)
            {
                Console.WriteLine("Digite o valor da temperatura que deseja converter");
                temp = double.Parse(Console.ReadLine());

                resultado = ((temp - 273) * 1.8) + 32;

                Console.WriteLine("O valor em Fahrenheit: " + resultado);
            }
            else if (number1 == number2)
            {
                Console.WriteLine("São as mesmas temperaturas, não tem como converter!");
            }
            Console.ReadKey();
        }
    }
}
