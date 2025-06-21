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

// ConsultarControl.cs
namespace ContaDeLuz.Telas_UserControl
{
    public partial class ConsultarControl : UserControl
    {
        private Form1 formPrincipal; 

        // Construtor com Form1 como parâmetro
        public ConsultarControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Voltar para o Menu Principal
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }

        private void dvgContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

