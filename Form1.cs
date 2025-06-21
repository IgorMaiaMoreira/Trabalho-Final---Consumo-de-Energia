// Importa os UserControls
using System.Windows.Forms;
// Form1.cs
namespace ControleDeLuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento do Paint pode continuar aí se precisar
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        // Carrega qualquer UserControl no painel
        public void TrocarTela(UserControl novaTela)
        {
            panelPrincipal.Controls.Clear();
            novaTela.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(novaTela);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carrega o menu principal na inicialização
            TrocarTela(new ContaDeLuz.Telas_UserControl.MenuPrincipalControl(this));
        }


    }
}
