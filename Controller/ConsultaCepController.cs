using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCep.Controller
{
    
    public class ConsultaCepController : IConsultaCepController
    {
        TextBox glbCep;
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        public static Boolean IsConnected()

        {

            int Description;

            return InternetGetConnectedState(out Description, 0);

        }

        public ConsultaCepController(TextBox parCep) 
        {
            glbCep = parCep;
        }

        public void ConsultarCep(ref TextBox parDados)
        {

            IConsultarCepServico ConsultaCepServico = new ConsultarCepServico();
            parDados.Clear();
            parDados.Text = ConsultaCepServico.ObterInformacoesCEP(Convert.ToInt32(glbCep.Text));
        }

        public bool ValidarCampo(ref string parMensagemErro)
        {

            if (!IsConnected())

            {
                parMensagemErro = "Não exite conexão ativa com a internet.";
                return false;
            }

            if (glbCep.Text == "")
            {
                parMensagemErro = "Informe um CEP para consultar.";
                return false;
            }

            if (glbCep.TextLength < 8)
            {
                parMensagemErro = "Informe um CEP com 8 digitos.";
                glbCep.Focus();
                return false;
            }

            if (!ValidaSomenteNumerosCEP())
            {
                parMensagemErro = "Informe somente números no CEP.";
                return false;
            }

            return true;
        }

        private bool ValidaSomenteNumerosCEP()
        {
            int cep;
            return int.TryParse(glbCep.Text, out cep);
        }
    }
}
