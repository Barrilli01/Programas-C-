using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        #region Métodos Simples
        // Métodos simples

        public void MostraNome(string nome)
        {
            Console.Write(nome);
        }

        public void Cumprimentar1(string nome, int hora)
        {
            string msg = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(msg);
        }
        #endregion

        #region Métodos Compostos
        // Métodos compostos

        public double Soma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }

        public string Cumprimentar2(string nome, int hora)
        {
            string msg = "";
            msg = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            
            return msg;

        }

        #endregion
    }
}
