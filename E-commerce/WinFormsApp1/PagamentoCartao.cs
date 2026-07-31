using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce
{
    public class PagamentoCartao : pagamento
    {
        public string NumeroCartao { get; set; }

        public string NomeTitular { get; set; }

        public string Validade { get; set; }


        public string Cvv { get; set; }

        public TipoCartao Tipo {  get; set; }
    }
}
