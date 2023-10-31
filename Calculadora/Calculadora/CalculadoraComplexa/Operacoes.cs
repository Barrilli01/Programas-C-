using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComplexa
{
    internal class Operacoes
    {
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
