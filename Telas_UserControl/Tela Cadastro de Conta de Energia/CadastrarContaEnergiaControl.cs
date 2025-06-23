using ControleDeLuz;
using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ContaDeLuz.Telas_UserControl
{
    public partial class CadastrarContaEnergiaControl : UserControl
    {
        private Form1 formPrincipal;

        private readonly IConsumidorDB _consumidorDB;
        private readonly IContaFactory _contaFactory;
        private readonly ContaDB _contaDB;

        private Consumidor _consumidorAtual;
        private IConta _contaAtual;

        public CadastrarContaEnergiaControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            // Instancia as nossas classes de lógica
            _consumidorDB = new ConsumidorDB();
            _contaFactory = new ContaFactory();
            _contaDB = new ContaDB();
            
        }

        private void CadastrarContaEnergiaControl_Load(object sender, EventArgs e)
        {
            ConfigurarEstadoInicial();
        }

        private void ConfigurarEstadoInicial()
        {
            textBox2.ReadOnly = true; 
            textBox5.ReadOnly = true; 
            textBox6.ReadOnly = true; 

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            grpDados.Enabled = false;
            btnCalcular.Enabled = false;
            btnSalvar.Enabled = false;

            textBox1.Clear(); 
            label4.Text = "{nome}";
            textBox2.Clear(); 
            textBox3.Clear(); 
            textBox4.Clear(); 
            textBox5.Clear(); 
            textBox6.Clear(); 
            radioButton1.Checked = true;

            _consumidorAtual = null!;
            _contaAtual = null!;

            textBox1.Focus();
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
                _consumidorAtual = _consumidorDB.BuscarPorDocumento(textBox1.Text);

                if (_consumidorAtual != null)
                {
                    label4.Text = _consumidorAtual.Nome;
                    textBox2.Text = _consumidorAtual.NumeroInstalacao.ToString();
                    
                    if (_consumidorAtual is PessoaFisica)
                    {
                        radioButton1.Checked = true;
                    }
                    else 
                    {
                        radioButton2.Checked = true;
                    }

                    grpDados.Enabled = true;
                    btnCalcular.Enabled = true;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox3.Text, out double leituraAnterior) ||
                !double.TryParse(textBox4.Text, out double leituraAtual))
            {
                MessageBox.Show("Verifique se as Leituras são números válidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            
            if (leituraAtual < leituraAnterior)
            {
                MessageBox.Show("A leitura atual não pode ser menor que a anterior.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            string tipoConta = radioButton1.Checked ? "residencial" : "comercial";
            
            _contaAtual = _contaFactory.CriarConta(tipoConta, _consumidorAtual.NumeroInstalacao, leituraAnterior, leituraAtual, _consumidorAtual);
            
            _contaAtual.LeituraMesAnterior = leituraAnterior;
            _contaAtual.LeituraMesAtual = leituraAtual;
            
            textBox5.Text = _contaAtual.CalcularConsumoKwh().ToString("F2", CultureInfo.InvariantCulture);
            textBox6.Text = _contaAtual.CalcularValorTotal().ToString("C", new CultureInfo("pt-BR"));

            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_contaAtual == null)
            {
                MessageBox.Show("Você precisa calcular os valores da conta antes de salvar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                _contaDB.Adicionar(_contaAtual);
                MessageBox.Show("Conta de energia salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfigurarEstadoInicial();
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                MessageBox.Show("Erro: Já existe uma conta cadastrada para este Número de Instalação.", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado ao salvar a conta: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_CadastrarConta_Click(object sender, EventArgs e)
        {
            ConfigurarEstadoInicial();
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }
        
        private void label5_Click(object sender, EventArgs e) { }
    }
}
