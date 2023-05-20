using Newtonsoft.Json;

namespace ConsultaCep
{
   public class CepJson
    {
        [JsonProperty("cep")]
        public string CEP { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("ibge")]
        public string IBGE { get; set; }
        [JsonProperty("gia")]
        public string GIA { get; set; }
        [JsonProperty("ddd")]
        public string DDD { get; set; }
        [JsonProperty("siafi")]
        public string Siafi { get; set; }
    }
}
