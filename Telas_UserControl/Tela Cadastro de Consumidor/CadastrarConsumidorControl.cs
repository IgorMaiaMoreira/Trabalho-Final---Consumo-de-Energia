// CadastrarConsumidorControl.cs
using ControleDeLuz;
using System;
using System.Windows.Forms;

namespace ContaDeLuz.Telas_UserControl
{
    public partial class CadastrarConsumidorControl : UserControl
    {
        private Form1 formPrincipal;

        public CadastrarConsumidorControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void CadastrarConsumidorControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_CadastroConsumidor_Click(object sender, EventArgs e)
        {
            // Volta pro menu principal
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }
    }
}
