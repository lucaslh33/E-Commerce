using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace Ecommerce
{

    public class EnderecoCEP
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Cidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }
}
