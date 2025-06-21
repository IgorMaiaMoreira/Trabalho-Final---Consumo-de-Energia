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

// RelatorioControl.cs
namespace ContaDeLuz.Telas_UserControl.Tela_Relatórios__Opcional_
{
    public partial class RelatorioControl : UserControl
    {
        private Form1 formPrincipal;

        // Construtor com referência ao Form1
        public RelatorioControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
      
        }

        private void btnVoltar_Relatorio_Click(object sender, EventArgs e)
        {
            // Voltar para o menu principal
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }

        private void RelatorioControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
