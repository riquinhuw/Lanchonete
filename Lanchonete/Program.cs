﻿using System;
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

        static void Main()
        {
            int respotaMenu = 0;
            
            Menu.Logo();

            //Estoque produto1 = new Estoque("Pao de Hambuguer",65);
            //Estoque produto2 = new Estoque("Hambuguer",50);
            //Estoque produto3 = new Estoque("Queijo Prato",50);
            //Estoque produto4 = new Estoque("Frango Assado",25);
            //Estoque produto5 = new Estoque("Refrigerante 300ml", 100);

                

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
