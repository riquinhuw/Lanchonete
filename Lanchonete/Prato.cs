using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Prato
    {
       // DANI-SE AS CLASSESSS VOU TACAR NO MAIN USANDO IF PQP

        public static void XBuguer()
        {
            Program.produto1.Quantidade = Program.produto1.Quantidade - 1; //Pao
            Program.produto2.Quantidade = Program.produto2.Quantidade - 1; // Carne
            Program.produto3.Quantidade = Program.produto3.Quantidade - 1; // Queijo
        }

        public static void XFrango()
        {
            Program.produto1.Quantidade = Program.produto1.Quantidade - 1; // Pao
            Program.produto3.Quantidade = Program.produto3.Quantidade - 1; // Queijo
            Program.produto4.Quantidade = Program.produto4.Quantidade - 1; // Frango
        }

        public static void Refrigerante()
        {
            Program.produto5.Quantidade = Program.produto5.Quantidade - 1; // Refri

        }


    }

}
