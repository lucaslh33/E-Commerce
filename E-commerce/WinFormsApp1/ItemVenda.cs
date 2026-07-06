using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    class ItemVenda
    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public decimal Total
        {
            get
            {
                return Preco * Quantidade;
            }
        }
    }


}
