using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
    public class ConsultarCepServico : IConsultarCepServico
    {
   
        public string ObterInformacoesCEP(int parCep)
        {

            HttpClient httpClient = new HttpClient();
            CepJson cepJson  = new CepJson();
         
            var response =  httpClient.GetAsync($"https://viacep.com.br/ws/{parCep}/json").Result;

            if (response.IsSuccessStatusCode) 
            {
                var result = response.Content.ReadAsStringAsync().Result;
                cepJson = JsonConvert.DeserializeObject<CepJson>(result);

                return MontaRetornoCEP(cepJson);
            }

            return string.Empty;
        }

        private string MontaRetornoCEP(CepJson cepJson)
        {
     
            TrataRetornoCepServico trataRetornoCep = new TrataRetornoCepServico(cepJson);
            return trataRetornoCep.ObterRetornoMontadoCEP();
        }
    }
}
