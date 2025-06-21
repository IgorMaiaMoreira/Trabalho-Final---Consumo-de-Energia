using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeLuz;

// Cadastrar Conta Energia Control
namespace ContaDeLuz.Telas_UserControl
{
    public partial class CadastrarContaEnergiaControl : UserControl
    {

        private Form1 formPrincipal;

        public CadastrarContaEnergiaControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        public CadastrarContaEnergiaControl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarContaEnergiaControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_CadastrarConta_Click(object sender, EventArgs e)
        {
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
