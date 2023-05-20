using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
    public interface IConsultarCepServico
    {
        string ObterInformacoesCEP(int parCep);
    }
}
