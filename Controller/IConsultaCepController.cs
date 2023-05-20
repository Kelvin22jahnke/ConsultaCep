using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCep.Controller
{
    public interface IConsultaCepController
    {
       
        bool ValidarCampo(ref string parMensagemErro);
        void ConsultarCep(ref TextBox parDados);
    }
}
