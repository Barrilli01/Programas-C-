using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCadastro
{

    internal class Menu
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Menu menu = new Menu();
            int num;

                do
                {
                    menu.MainMenu();
                    num = int.Parse(Console.ReadLine());
                    
                    Console.Clear();

                    switch (num)
                    {
                        case 0:
                            Console.WriteLine("Encerrado");
                            break;
                        case 1:
                            pessoa.Adicionar();
                            break;
                        case 2:
                            pessoa.Listar();
                            break;
                        default:
                            Console.WriteLine("Número digitado não identificado no menu");
                            Console.WriteLine("Digite uma opção do menu!");
                            num = int.Parse(Console.ReadLine());
                            break;
                    }

                } while (num == 1 || num == 2);

           
            Console.ReadKey();
        }

        public void MainMenu()
        {
            Console.WriteLine("BEM VINDO AO MENU!");
            Console.WriteLine("1 - PARA ADICIONAR PESSOA");
            Console.WriteLine("2 - PARA LISTAR PESSOA");
            Console.WriteLine("0 - PARA ENCERRAR SESSÃO");
        }
    }
}
