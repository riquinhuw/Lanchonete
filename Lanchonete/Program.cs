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

        static void Main()
        {
            int respotaMenu = 0;
            bool looping = true;
            do
            {
                Menu.Logo();
                Menu.MenuInicial();
                respotaMenu = int.Parse(Console.ReadLine());

                switch (respotaMenu)
                {
                    //Vender produto
                    case 1:

                        Funcoes.Vender();
                        break;

                    case 2:
                        Funcoes.FecharConta();
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
