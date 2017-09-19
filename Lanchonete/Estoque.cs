using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Estoque
    {
        #region Propriedades
        private string nome;
        private int quantidade;
        #endregion

        #region Encapsulamento
        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        #endregion



        Estoque(string nome, int quantidade)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            
        }

    }
}
