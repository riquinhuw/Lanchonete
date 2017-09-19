using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            int respotaMenu = 0;
            Menu.Logo();

            Estoque produto1 = new Estoque("Pao de Hambuguer",65);
            Estoque produto2 = new Estoque("Hambuguer",50);
            Estoque produto3 = new Estoque("Queijo Prato",50);
            Estoque produto4 = new Estoque("Frango Assado",25);
            Estoque produto5 = new Estoque("Refrigerante 300ml", 100);

           produto1.Quantidade = Prato.Hambuguer2(produto1.Quantidade);


            Console.WriteLine(produto1.Quantidade);

            Menu.MenuInicial();
            respotaMenu = int.Parse(Console.ReadLine());

            switch (respotaMenu)
            {
                //Vender produto
                case 1:



                break;


            }

        }
    }
}
