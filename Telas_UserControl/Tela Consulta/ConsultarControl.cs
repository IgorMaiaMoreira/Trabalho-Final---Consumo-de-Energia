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
using System.Globalization;


// ConsultarControl.cs
namespace ContaDeLuz.Telas_UserControl
{
    public partial class ConsultarControl : UserControl
    {
        private Form1 formPrincipal;
        private readonly IConsumidorDB _consumidorDB;
        private readonly ContaDB _contaDB;
        private Consumidor _consumidorBuscar;
        private IConta _contaAtual;


        // Construtor com Form1 como parâmetro
        public ConsultarControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            _consumidorDB = new ConsumidorDB();
            _contaDB = new ContaDB();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Voltar para o Menu Principal
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, digite um CPF ou CNPJ para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _consumidorBuscar = _consumidorDB.BuscarPorDocumento(textBox1.Text);

                if (_consumidorBuscar != null)
                {
                    label5.Text = _consumidorBuscar.Nome;
                    label6.Text = _consumidorBuscar.NumeroInstalacao.ToString();

                    _contaAtual = _contaDB.BuscarPorUsuario(_consumidorBuscar);

                    if (_contaAtual != null)
                    {                        
                        CarregarContasNoDataGridView(new List<IConta> { _contaAtual });
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma conta de luz associada a este consumidor.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Consumidor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfigurarEstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao buscar o consumidor: {ex.Message}", "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
         private void CarregarContasNoDataGridView(List<IConta> contas)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nº da Instalação", typeof(int));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Consumo", typeof(string));
            dt.Columns.Add("Valor Total", typeof(string));

            foreach (var conta in contas)
            {
                double consumoCalculado = conta.CalcularConsumoKwh();
                double valorTotalCalculado = conta.CalcularValorTotal(); 

                dt.Rows.Add(
                    conta.NumeroInstalacao,
                    conta.GetType().Name.Replace("Conta", ""),
                    consumoCalculado.ToString("F2", CultureInfo.InvariantCulture),
                    valorTotalCalculado.ToString("C", new CultureInfo("pt-BR"))
                );
            }

            dvgContas.DataSource = dt; // Atribui o DataTable como fonte de dados
            // dvgContas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 
            // Use dvgContas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            // como definido no designer, ou se preferir ajusta por aqui com AllCells.
            // Se já está no designer, pode remover essa linha do código ou manter se quiser sobrescrever.
        }

        private void dvgContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigurarEstadoInicial() {
            textBox1.Text = "";
            label5.Text = "-";
            label6.Text = "-";
        }
        
    }
}

