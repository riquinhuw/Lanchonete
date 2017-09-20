using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Program
    {
        public static Estoque produto1 = new Estoque("Pao de Hambuguer", 65);
        public static Estoque produto2 = new Estoque("Hambuguer", 50);
        public static Estoque produto3 = new Estoque("Queijo Prato", 50);
        public static Estoque produto4 = new Estoque("Frango Assado", 25);
        public static Estoque produto5 = new Estoque("Refrigerante 300ml", 100);
        public static Mesa mesa1 = new Mesa(1,00.00);
        public static Mesa mesa2 = new Mesa(2, 00.00);
        public static Mesa mesa3 = new Mesa(3, 00.00);
        public static Mesa mesa4 = new Mesa(4, 00.00);
        public static Mesa mesa5 = new Mesa(5, 00.00);
        public static double ganhoDoDia = 00.00;

        static void Main()
        {
            int respotaMenu = 0;
            bool looping = true;
            do
            {
                Console.Clear();
                Menu.Logo();
                Menu.MenuInicial();
                respotaMenu = int.Parse(Console.ReadLine());

                switch (respotaMenu)
                {
                    //Vender produto
                    case 1:
                        
                        Console.WriteLine("VENDER");
                        Funcoes.Vender();
                        break;

                    case 2:
                        Funcoes.FecharConta();
                        break;

                    case 3:
                        Console.Clear();
                        Menu.Logo();
                        Console.WriteLine("ESTOQUE\n\n");
                        Console.WriteLine("{0} possiu {1} unidades",produto1.Nome,produto1.Quantidade);
                        Console.WriteLine("{0} possiu {1} unidades",produto2.Nome,produto2.Quantidade);
                        Console.WriteLine("{0} possiu {1} unidades",produto3.Nome,produto3.Quantidade);
                        Console.WriteLine("{0} possiu {1} unidades",produto4.Nome,produto4.Quantidade);
                        Console.WriteLine("{0} possiu {1} unidades",produto5.Nome,produto5.Quantidade);
                        break;

                    case 4:
                        Console.Clear();
                        Menu.Logo();

                        Console.WriteLine("O ganho do dia foi de {0}R$", ganhoDoDia);
                        Console.WriteLine("Deseja sair do programa?(s/n)");
                        if (Console.ReadLine() == "s") { looping = false; }
                        break;

                    case 5:
                        Console.WriteLine("Deseja realemente sair?(s/n)");
                        if(Console.ReadLine() == "s") { looping = false; }


                        break;

                    default:
                        looping = false;
                        break;
                }
            } while (looping);
        }

        static void Sair()
        {
            Console.WriteLine("Você deseja continuar?(s/n)");
            
        }

        public static void VenderHambuguer()
        {

            Console.WriteLine("haha");

        }
    }
}
