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
            int escolhaVenda = 0;
            string nome1;
            double preco1;
            string nome2;
            double preco2;
            string nome3;
            double preco3;
            string nome4;
            double preco4;
            string nome5;
            double preco5;

            string nome;
            double preco;

            do
            {
                Console.WriteLine("Selecione algo para vender");
                Console.WriteLine("1 - XBuguer\n2 - XFrango\n3 - Refrigerante");
                escolhaVenda = int.Parse(Console.ReadLine());
                switch (escolhaVenda)
                {
                    case 1:
                        nome = "XBuguer";
                        preco = 10.00;
                    break;

                    case 2:
                        nome = "XFrango";
                        preco = 9.00;
                    break;

                    case 3:
                        nome = "Refrigerante";
                        preco = 3.00;
                    break;


                }

                

                Console.WriteLine("Deseja fazer outra venda?");
                respostaLooping = Console.ReadLine();
                if (respostaLooping == "n") { loopingVenda = false; }
            } while (loopingVenda);
        }



    }
}
