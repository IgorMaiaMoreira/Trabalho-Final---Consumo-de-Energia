using ControleDeLuz; 
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ContaDeLuz.Telas_UserControl
{
    public partial class CadastrarConsumidorControl : UserControl
    {
        private Form1 formPrincipal;
        private readonly IConsumidorDB _consumidorDB;
        
        // Declaramos as variáveis para os novos controlos que serão criados via código.
        private Label labelNumeroInstalacao;
        private TextBox textBoxNumeroInstalacao;

        public CadastrarConsumidorControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            _consumidorDB = new ConsumidorDB();

            // Chamamos um método para criar e configurar os controlos adicionais.
            InicializarControlosAdicionais();

            // Conectamos todos os eventos manualmente para garantir o funcionamento.
            this.Load += new System.EventHandler(this.CadastrarConsumidorControl_Load!);
            this.btnSalvarConsumidor.Click += new System.EventHandler(this.btnSalvarConsumidor_Click!);
            this.btnCancelar_CadastroConsumidor.Click += new System.EventHandler(this.btnCancelar_CadastroConsumidor_Click!);
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged!);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged!);
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click!);
        }
        
        private void InicializarControlosAdicionais()
        {
            // Cria o Label para "Nº da Instalação"
            this.labelNumeroInstalacao = new Label();
            this.labelNumeroInstalacao.AutoSize = true;
            this.labelNumeroInstalacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelNumeroInstalacao.Location = new Point(200, 370);
            this.labelNumeroInstalacao.Name = "labelNumeroInstalacao";
            this.labelNumeroInstalacao.Text = "Nº da Instalação:";

            // Cria o TextBox para o número da instalação
            this.textBoxNumeroInstalacao = new TextBox();
            this.textBoxNumeroInstalacao.Location = new Point(375, 368);
            this.textBoxNumeroInstalacao.Name = "textBoxNumeroInstalacao";
            this.textBoxNumeroInstalacao.Size = new Size(232, 23);

            // Adiciona os novos controlos ao formulário
            this.Controls.Add(this.labelNumeroInstalacao);
            this.Controls.Add(this.textBoxNumeroInstalacao);
        }

        private void CadastrarConsumidorControl_Load(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnSalvarConsumidor_Click(object sender, EventArgs e)
        {
            // Validações dos campos de entrada
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("O campo 'Nome / Razão Social' é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("O campo 'CPF / CNPJ' deve ser preenchido completamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxNumeroInstalacao.Text, out int numeroInstalacao))
            {
                MessageBox.Show("O Número da Instalação deve ser um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria o objeto Consumidor
            Consumidor consumidor = radioButton1.Checked
                ? (Consumidor)new PessoaFisica { Nome = textBox1.Text, CPF = maskedTextBox1.Text, NumeroInstalacao = numeroInstalacao }
                : new PessoaJuridica { Nome = textBox1.Text, CNPJ = maskedTextBox1.Text, NumeroInstalacao = numeroInstalacao };

            // Tenta adicionar ao banco de dados
            try
            {
                _consumidorDB.Adicionar(consumidor);
                MessageBox.Show("Consumidor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                MessageBox.Show("Erro: O CPF/CNPJ ou o Nº da Instalação informado já existe.", "Dados Duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_CadastroConsumidor_Click(object sender, EventArgs e)
        {
            formPrincipal.TrocarTela(new MenuPrincipalControl(formPrincipal));
        }

        private void LimparFormulario()
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            if (textBoxNumeroInstalacao != null)
            {
                textBoxNumeroInstalacao.Clear(); 
            }
            radioButton1.Checked = true;
            textBox1.Focus();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                AtualizarMascaraDocumento();
            }
        }

        private void AtualizarMascaraDocumento()
        {
            if (radioButton1.Checked)
            {
                label3.Text = "CPF:";
                maskedTextBox1.Mask = "000.000.000-00";
            }
            else
            {
                label3.Text = "CNPJ:";
                maskedTextBox1.Mask = "00.000.000/0000-00";
            }
            maskedTextBox1.Clear();
            maskedTextBox1.Select(0, 0);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Select(0, 0);
        }
    }
}
