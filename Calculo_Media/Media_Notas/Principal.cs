using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Notas
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            int continuar;
            int totalNotas = 0;
            double valorTotal = 0;
            
            CalculoNotas calc = new CalculoNotas();

            Console.WriteLine("Digite a 1 nota");
            valorTotal += double.Parse(Console.ReadLine());
            totalNotas++;
            Console.WriteLine("Digite a 2 nota");
            valorTotal += double.Parse(Console.ReadLine());
            totalNotas++;

            Console.WriteLine("Deseja adicionar mais alguma nota?");
            Console.WriteLine("Digite 1 para sim e 0 para não");
            continuar = int.Parse(Console.ReadLine());

            while (continuar != 0)
            {
                totalNotas++;
                Console.WriteLine("Digite a nota " + totalNotas);
                valorTotal += double.Parse(Console.ReadLine());

                Console.WriteLine("Deseja adicionar mais alguma nota?");
                Console.WriteLine("Digite 1 para sim e 0 para não");
                continuar = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Essa é a média do aluno: " + calc.CalculoMedia(valorTotal, totalNotas));

            Console.ReadKey();
        }
    }
}
