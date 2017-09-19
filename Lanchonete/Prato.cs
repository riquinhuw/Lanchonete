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

        public static Estoque Hambuguer(Estoque entradaComida )
        {
            Estoque entrada = entradaComida;
            entrada.Quantidade = entrada.Quantidade - 1;

            return entrada;
        }

        public static int Hambuguer2(int entradaComida)
        {
            
            entradaComida = entradaComida - 1;
            return entradaComida;
        }


    }

}
