using ConsultaCep.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCep
{
    public partial class frmConsultaCep : Form
    {
        public frmConsultaCep()
        {
            InitializeComponent();
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IConsultaCepController consultaCepController = new ConsultaCepController(txtCep);
            string mensagemErro = string.Empty;

            if (!consultaCepController.ValidarCampo(ref mensagemErro)) 
            {
                txtCep.Focus();
                MessageBox.Show(mensagemErro);
                return;
            }

            consultaCepController.ConsultarCep(ref txtDados);

        }

    }
}
