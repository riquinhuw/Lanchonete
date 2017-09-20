using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Mesa
    {

        private int numero;
        private double gasto;

        public int Numero { get => numero; set => numero = value; }
        public double Gasto { get => gasto; set => gasto = value; }


        public Mesa(int numero, double gasto)
        {
            this.numero = numero;

            this.gasto = gasto;


        }
    }
}
