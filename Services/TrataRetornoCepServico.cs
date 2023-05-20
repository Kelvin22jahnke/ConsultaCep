using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
   public class TrataRetornoCepServico
    {
        private CepJson glbCepJson;

        public TrataRetornoCepServico(CepJson cepJson) 
        {
            glbCepJson = cepJson;
        }

        public string ObterRetornoMontadoCEP() 
        {
            string cepRetorno;

            cepRetorno = $"Retorno do CEP: {glbCepJson.CEP}" + Environment.NewLine;
            cepRetorno += $"Logradouro: {ObterCampoLogradouro()}" + Environment.NewLine;
            cepRetorno += $"Bairro: {ObterCampoBairro()}" + Environment.NewLine;
            cepRetorno += $"Complemento: {ObterCampoComplemento()}" + Environment.NewLine;
            cepRetorno += $"Cidade: {ObterCampoLocalidade()}" + Environment.NewLine;
            cepRetorno += $"DDD: {ObterCampoDDD()}" + Environment.NewLine;
            cepRetorno += $"GIA: {ObterCampoGIA()}" + Environment.NewLine;
            cepRetorno += $"SIAFI: {ObterCampoSIAFI()}";
            
            return cepRetorno;
        }

        private string ObterCampoBairro() 
        {

            if (glbCepJson.Bairro == string.Empty) 
            {
                return "O Campo Bairro não possui informação.";
            }

            return glbCepJson.Bairro;
        }

        private string ObterCampoComplemento()
        {

            if (glbCepJson.Complemento == string.Empty)
            {
                return "O Campo Complemento não possui informação.";
            }

            return glbCepJson.Complemento;
        }

        private string ObterCampoDDD()
        {

            if (glbCepJson.DDD  == string.Empty)
            {
                return "O Campo DDD não possui informação.";
            }

            return glbCepJson.DDD;
        }

        private string ObterCampoGIA()
        {

            if (glbCepJson.GIA == string.Empty)
            {
                return "O Campo GIA não possui informação.";
            }

            return glbCepJson.GIA;
        }

        private string ObterCampoLogradouro()
        {

            if (glbCepJson.Logradouro == string.Empty)
            {
                return "O Campo Logradouro não possui informação.";
            }

            return glbCepJson.Logradouro;
        }

        private string ObterCampoLocalidade()
        {

            if (glbCepJson.Localidade == string.Empty)
            {
                return "O Campo Localidade não possui informação.";
            }

            return glbCepJson.Localidade;
        }

        private string ObterCampoSIAFI()
        {

            if (glbCepJson.Siafi == string.Empty)
            {
                return "O Campo SIAFI não possui informação.";
            }

            return glbCepJson.Siafi;
        }

    }
}
