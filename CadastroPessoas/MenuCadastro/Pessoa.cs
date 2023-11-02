using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuCadastro
{
    struct dadosPessoa
    {
        public string nome;
        public int idade;
        public int celular;

        public void dadosP(string nome, int idade, int celular)
        {
            this.nome = nome;
            this.idade = idade;
            this.celular = celular;
        }
        public void Info()
        {
            Console.WriteLine("   Nome : {0}", this.nome);
            Console.WriteLine("   Idade : {0}", this.idade);
            Console.WriteLine("   Celular : {0}", this.celular);
        }
    }

    internal class Pessoa
    {
        public int totalP = 0;
        dadosPessoa[] p = new dadosPessoa[10];

        public void Adicionar()
        {
            string nome;
            int idade;
            int celular;

            Console.WriteLine("Digite o nome da pessoa " + totalP);
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite a idade da pessoa " + totalP);
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o número de celular da pessoa " + totalP);
            celular = int.Parse(Console.ReadLine());

            p[totalP].nome = nome;
            p[totalP].idade = idade;
            p[totalP].celular = celular;

            totalP++;

            int qtt = p.Length - totalP;
            Console.WriteLine();
            Console.WriteLine("Pessoa adicionada!");
            Console.WriteLine("Você ainda pode adicionar mais " + qtt + " pessoas");
            Console.ReadKey();
            Console.Clear();
        }

        public void Listar()
        {
            for (int i = 0; i < totalP; i++) {
                
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine();
                p[i].Info();

            }
            Console.ReadKey();
            Console.Clear();
        }

       
    }
}
