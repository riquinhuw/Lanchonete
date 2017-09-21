using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Menu
    {
        //Parte visual do programa

        public static void Logo()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                 _                   _                                 ");
            Console.WriteLine(@" _ __   ___   __| |_ __ __ _  ___   | |__  _   _  __ _ _   _  ___ _ __ ");
            Console.WriteLine(@"| '_ \ / _ \ / _` | '__/ _` |/ _ \  | '_ \| | | |/ _` | | | |/ _ \ '__|");
            Console.WriteLine(@"| |_) | (_) | (_| | | | (_| | (_) | | |_) | |_| | (_| | |_| |  __/ |   ");
            Console.WriteLine(@"| .__/ \___/ \__,_|_|  \__,_|\___/  |_.__/ \__,_|\__, |\__,_|\___|_|   ");
            Console.WriteLine(@"|_|                                              |___/                 ");
            Console.WriteLine("\n\n");
            Console.ResetColor();
        }

        public static void MenuInicial()
        {
            Console.WriteLine("Escolha uma opcao:");
            Console.WriteLine("1 - Vender Lanche\n2 - Fechar conta\n3 - Estoque\n4 - Ganho do Dia\n5 - Sair\n");

        }


        
        
    }

}
