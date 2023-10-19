using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicação_de_matrizes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            int[,] matriz = new int[2, 3];

            matriz[0, 0] = 5;
            matriz[0, 1] = 4;
            matriz[0, 2] = 6;
            
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 2;

            int[,] matriz2 = new int[3, 2];

            matriz2[0, 0] = 4;
            matriz2[0, 1] = 2;

            matriz2[1, 0] = 6;
            matriz2[1, 1] = 4;

            matriz2[2, 0] = 1;
            matriz2[2, 1] = 6;

            int[,] resultado = new int[2, 2];

            resultado[0, 0] = (matriz[0, 0] * matriz2[0, 0]) + (matriz[0, 1] * matriz2[1, 0]) + (matriz[0, 2] * matriz2[2, 0]);
            resultado[1, 0] = (matriz[1, 0] * matriz2[0, 0]) + (matriz[1, 1] * matriz2[1, 0]) + (matriz[1, 2] * matriz2[2, 0]);
            resultado[0, 1] = (matriz[0, 0] * matriz2[0, 1]) + (matriz[0, 1] * matriz2[1, 1]) + (matriz[0, 2] * matriz2[2, 1]);
            resultado[1, 1] = (matriz[1, 0] * matriz2[0, 1]) + (matriz[1, 1] * matriz2[1, 1]) + (matriz[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0, 0] + "][" + resultado[0, 1] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "][" + resultado[1, 1] + "]");

            Console.ReadKey();

        }
        }
}
