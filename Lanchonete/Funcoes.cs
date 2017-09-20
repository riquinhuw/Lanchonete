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
            double preco = 0;

            int numeroMesa=0;

            do
            {
                Console.Clear();
                Menu.Logo();
                string venderMais = "s";
                preco = 00.00;
                while (venderMais !="n") {
                    Console.WriteLine("Selecione algo para vender");
                    Console.WriteLine("1 - XBuguer\n2 - XFrango\n3 - Refrigerante");
                    escolhaVenda = int.Parse(Console.ReadLine());
                    switch (escolhaVenda)
                    {
                        case 1:
                            nome = "XBuguer";
                            preco = preco + 10.00;
                            Prato.XBuguer();
                            break;

                        case 2:
                            nome = "XFrango";
                            preco = preco + 9.00;
                            Prato.XFrango();
                            break;

                        case 3:
                            nome = "Refrigerante";
                            preco = preco + 3.00;
                            Prato.Refrigerante();
                            break;


                    }

                    Console.WriteLine("Deseja comprar outro lanche?");
                    venderMais = Console.ReadLine();
                }
                Console.Clear();
                Menu.Logo();
                Console.WriteLine("Digite o numero da mesa");
                numeroMesa= int.Parse(Console.ReadLine());
                switch (numeroMesa)
                {
                    case 1:
                        Program.mesa1.Gasto = Program.mesa1.Gasto + preco;
                        Program.ganhoDoDia = Program.ganhoDoDia + preco;
                    break;


                    case 2:
                        Program.mesa2.Gasto = Program.mesa2.Gasto + preco;
                        Program.ganhoDoDia = Program.ganhoDoDia + preco;
                        break;

                    case 3:
                        Program.mesa3.Gasto = Program.mesa3.Gasto + preco;
                        Program.ganhoDoDia = Program.ganhoDoDia + preco;
                        break;

                    case 4:
                        Program.mesa4.Gasto = Program.mesa4.Gasto + preco;
                        Program.ganhoDoDia = Program.ganhoDoDia + preco;
                        break;

                    case 5:
                        Program.mesa5.Gasto = Program.mesa5.Gasto + preco;
                        Program.ganhoDoDia = Program.ganhoDoDia + preco;
                        break;
                }

                Console.WriteLine("Deseja fazer outra venda?");
                respostaLooping = Console.ReadLine();
                if (respostaLooping == "n") { loopingVenda = false; } //posso usar um != "n" para manter o looping
            } while (loopingVenda);
        }

        public static void FecharConta()
        {
            Console.Clear();
            Menu.Logo();
            int numeroDaMesaAFechar=0;
            Console.WriteLine("Digite a mesa que deseja FECHAR:");
            numeroDaMesaAFechar = int.Parse(Console.ReadLine());
            double pagamento = 0;
            double recebido = 0;
            switch (numeroDaMesaAFechar)
            {
                case 1:

                    Console.WriteLine("A mesa 1 consumiu no total {0}R$",Program.mesa1.Gasto);
                    #region Metodo de Pagamento
                    Console.WriteLine("Escolha a forma de pagamento:/n");
                    Console.WriteLine("1-Debito\n2-Credito\n3-A vista\n");
                    pagamento = double.Parse(Console.ReadLine());
                    switch (pagamento)
                    {
                        //Debito
                        case 1:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //Credito
                        case 2:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //a vista
                        case 3:

                            Console.WriteLine("TOTAL A PAGAR:{0}R$", Program.mesa1.Gasto);
                            Console.WriteLine("Digite o valor recebido");
                            recebido = double.Parse(Console.ReadLine());
                            Console.WriteLine("O Troco é de {0}R$", recebido - Program.mesa1.Gasto);
                            Console.WriteLine("Ogrigada pela compra, VOLTE SEMPRE");
                            break;
                    }
                    #endregion

                    break;

                case 2:

                    Console.WriteLine("A mesa 1 consumiu no total {0}R$", Program.mesa2.Gasto);
                    #region Metodo de Pagamento
                    Console.WriteLine("Escolha a forma de pagamento:/n");
                    Console.WriteLine("1-Debito\n2-Credito\n3-A vista\n");
                    pagamento = double.Parse(Console.ReadLine());
                    switch (pagamento)
                    {
                        //Debito
                        case 1:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //Credito
                        case 2:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //a vista
                        case 3:

                            Console.WriteLine("TOTAL A PAGAR:{0}R$", Program.mesa2.Gasto);
                            Console.WriteLine("Digite o valor recebido");
                            recebido = double.Parse(Console.ReadLine());
                            Console.WriteLine("O Troco é de {0}R$", recebido - Program.mesa2.Gasto);
                            Console.WriteLine("Ogrigada pela compra, VOLTE SEMPRE");
                            break;
                    }
                    #endregion
                    break;

                case 3:

                    Console.WriteLine("A mesa 1 consumiu no total {0}R$", Program.mesa3.Gasto);
                    #region Metodo de Pagamento
                    Console.WriteLine("Escolha a forma de pagamento:/n");
                    Console.WriteLine("1-Debito\n2-Credito\n3-A vista\n");
                    pagamento = double.Parse(Console.ReadLine());
                    switch (pagamento)
                    {
                        //Debito
                        case 1:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //Credito
                        case 2:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //a vista
                        case 3:

                            Console.WriteLine("TOTAL A PAGAR:{0}R$", Program.mesa3.Gasto);
                            Console.WriteLine("Digite o valor recebido");
                            recebido = double.Parse(Console.ReadLine());
                            Console.WriteLine("O Troco é de {0}R$", recebido - Program.mesa3.Gasto);
                            Console.WriteLine("Ogrigada pela compra, VOLTE SEMPRE");
                            break;
                    }
                    #endregion
                    break;

                case 4:

                    Console.WriteLine("A mesa 1 consumiu no total {0}R$", Program.mesa4.Gasto);
                    #region Metodo de Pagamento
                    Console.WriteLine("Escolha a forma de pagamento:/n");
                    Console.WriteLine("1-Debito\n2-Credito\n3-A vista\n");
                    pagamento = double.Parse(Console.ReadLine());
                    switch (pagamento)
                    {
                        //Debito
                        case 1:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //Credito
                        case 2:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //a vista
                        case 3:

                            Console.WriteLine("TOTAL A PAGAR:{0}R$", Program.mesa4.Gasto);
                            Console.WriteLine("Digite o valor recebido");
                            recebido = double.Parse(Console.ReadLine());
                            Console.WriteLine("O Troco é de {0}R$", recebido - Program.mesa4.Gasto);
                            Console.WriteLine("Ogrigada pela compra, VOLTE SEMPRE");
                            break;
                    }
                    #endregion
                    break;

                case 5:

                    Console.WriteLine("A mesa 1 consumiu no total {0}R$", Program.mesa5.Gasto);
                    #region Metodo de Pagamento
                    Console.WriteLine("Escolha a forma de pagamento:/n");
                    Console.WriteLine("1-Debito\n2-Credito\n3-A vista\n");
                    pagamento = double.Parse(Console.ReadLine());
                    switch (pagamento)
                    {
                        //Debito
                        case 1:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //Credito
                        case 2:
                            Console.WriteLine("Insira o cartão");
                            Console.ReadLine();
                            Console.WriteLine("Digite a senha");
                            Console.ReadLine();
                            Console.WriteLine("Compra feito com sucesso\n\n");
                            Console.WriteLine("Obrigada pela compra, volte sempre :)");
                            break;
                        //a vista
                        case 3:

                            Console.WriteLine("TOTAL A PAGAR:{0}R$", Program.mesa5.Gasto);
                            Console.WriteLine("Digite o valor recebido");
                            recebido = double.Parse(Console.ReadLine());
                            Console.WriteLine("O Troco é de {0}R$", recebido - Program.mesa5.Gasto);
                            Console.WriteLine("Ogrigada pela compra, VOLTE SEMPRE");
                            break;
                    }
                    #endregion
                    break;


            }



        }



    }
}
