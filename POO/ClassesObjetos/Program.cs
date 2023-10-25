using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Objetos 
            /*
            MinhaClasse mClasse1 = new MinhaClasse();
            MinhaClasse mClasse2 = new MinhaClasse();

            OutraClasse oClasse1 = new OutraClasse();
            OutraClasse oClasse2 = new OutraClasse();
            */
            #endregion

            Pessoa p1 = new Pessoa();

            p1.nome = "Gabriel";
            p1.sobrenome = "Barrilli";
            p1.anoNascimento = 2004;

            p1.Apresentar();

            Console.ReadKey();
        }

    }
       
    class MinhaClasse
    {
    }
}
