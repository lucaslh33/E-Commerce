using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    public class pagamento
    {
        public int FormaPagamento { get; set;  }

        public decimal ValorCompra {  get; set; }

        public decimal ValorRecebido { get; set; }

        public decimal Troco
        {
            get
            {
                return ValorRecebido - ValorCompra;
            }
        }

        public bool PagamentoAprovado()
        {
            return ValorRecebido >= ValorCompra;
        }
    }
}
