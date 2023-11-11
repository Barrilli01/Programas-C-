using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Notas
{
    internal class CalculoNotas
    {
        public double CalculoMedia(double notas, double totalNotas)
        {

            double resultado = notas / totalNotas;

            return resultado;
        }
    }
}
