using ContaDeLuz.Telas_UserControl.Tela_Relatórios__Opcional_;
using ControleDeLuz;
using System;
using System.Windows.Forms;
// MenuPrincipalControl.cs
namespace ContaDeLuz.Telas_UserControl
{
    public partial class MenuPrincipalControl : UserControl
    {
        private Form1 formPrincipal; // Referência ao Form Principal

        //Construtor com Form1 como parâmetro
        public MenuPrincipalControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void MenuPrincipalControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        // EVENTO DE CLICKS PARA TROCAR AS TELAS EM MENU INICIAL
        private void btnCadastrarConsumidor_Click(object sender, EventArgs e)
        {
            formPrincipal.TrocarTela(new CadastrarConsumidorControl());
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            formPrincipal.TrocarTela(new CadastrarContaEnergiaControl());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            formPrincipal.TrocarTela(new ConsultarControl());
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            formPrincipal.TrocarTela(new RelatorioControl());
        }
    }
}
