using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Funcoes
    {

        public static void Vender()
        {
            bool loopingVenda = true;
            string respostaLooping;

            do
            {
                Console.WriteLine("Selecione algo para vender");
                Console.WriteLine("1 - XBuguer\n2 - XFrango\n3 - Refrigerante");

                Console.WriteLine("Deseja fazer outra venda?");
                respostaLooping = Console.ReadLine();
                if (respostaLooping == "n") { loopingVenda = false; }
            } while (loopingVenda);
        }



    }
}
