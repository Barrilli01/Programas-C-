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
        public string idade;
        public string celular;

        public void dadosP(string nome, string idade, string celular)
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
        dadosPessoa[] p = new dadosPessoa[11];

        public void Adicionar()
        {
            string nome;
            string idade;
            string celular;

            Console.WriteLine("Digite o nome da pessoa " + (totalP + 1));
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite a idade da pessoa " + (totalP + 1));
            idade = (Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o número de celular da pessoa " + (totalP + 1));
            celular = (Console.ReadLine());

            int indice = totalP + 1;

            p[totalP].nome = nome;
            p[totalP].idade = idade;
            p[totalP].celular = celular;

            totalP++;

            int qtt = p.Length - totalP - 1;
            Console.WriteLine();
            Console.WriteLine("Pessoa adicionada!");
            Console.WriteLine("Você ainda pode adicionar mais " + qtt + " pessoas");
            Console.ReadKey();
            Console.Clear();
        }

        public void Listar()
        {
            Console.WriteLine();

            if (totalP > 0)
            {
                Console.WriteLine("--------------------");
                int indice = 1;

                for (int i = 0; i < totalP; i++)
                {

                    Console.WriteLine();
                    Console.WriteLine("   Índice: " + indice);
                    p[i].Info();
                    Console.WriteLine();
                    Console.WriteLine("--------------------");

                    indice++;
                }
            }
            else
            {
                Console.WriteLine("Ainda não há pessoas cadastradas!");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Atualizar()
        {

            int num;

            Console.WriteLine();

            if (totalP > 0)
            {

                Console.WriteLine("--------------------");
                int indice = 1;

                for (int i = 0; i < totalP; i++)
                {

                    Console.WriteLine();
                    Console.WriteLine("   Índice: " + indice);
                    p[i].Info();
                    Console.WriteLine();
                    Console.WriteLine("--------------------");

                    indice++;
                }

                Console.WriteLine("Estas são as pessoas cadastradas, digite um dos índices disponíveis para atualizar");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo nome");
                p[num - 1].nome = Console.ReadLine();
                Console.WriteLine("Digite a nova idade");
                p[num - 1].idade = Console.ReadLine();
                Console.WriteLine("Digite o novo número de celular");
                p[num - 1].celular = Console.ReadLine();

                Console.WriteLine("Cadastro atualizado!");

            }
            else
            {
                Console.WriteLine("Ainda não há pessoas cadastradas!");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Deletar()
        {

            int num;

            Console.WriteLine();

            if (totalP > 0)
            {
                Console.WriteLine("--------------------");
                int indice = 1;

                for (int i = 0; i < totalP; i++)
                {

                    Console.WriteLine();
                    Console.WriteLine("   Índice: " + indice);
                    p[i].Info();
                    Console.WriteLine();
                    Console.WriteLine("--------------------");

                    indice++;
                }

                Console.WriteLine("Estas são as pessoas cadastradas, digite um dos índices disponíveis para deletar");
                num = int.Parse(Console.ReadLine());

                p[num - 1].nome = "";
                p[num - 1].idade = "";
                p[num - 1].celular = "";

                Console.WriteLine("Cadastro deletado!");
            }
            else
            {
                Console.WriteLine("Ainda não há pessoas cadastradas!");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
