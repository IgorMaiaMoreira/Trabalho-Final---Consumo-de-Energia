using ControleDeLuz; 
using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ContaDeLuz.Telas_UserControl
{
    public partial class CadastrarConsumidorControl : UserControl
    {
        private Form1 formPrincipal;
        private readonly IConsumidorDB _consumidorDB;

        public CadastrarConsumidorControl(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            // Instancia a classe concreta que sabe como falar com o SQLite.
            _consumidorDB = new ConsumidorDB();

            // Conecta manualmente todos os eventos para garantir o funcionamento independentemente do arquivo Designer.
            this.btnSalvarConsumidor.Click += new System.EventHandler(this.btnSalvarConsumidor_Click);
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
        }

        private void CadastrarConsumidorControl_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            AtualizarMascaraDocumento();
        }

        private void btnSalvarConsumidor_Click(object sender, EventArgs e)
        {
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

            Consumidor consumidor = radioButton1.Checked
                ? (Consumidor)new PessoaFisica { Nome = textBox1.Text, CPF = maskedTextBox1.Text }
                : new PessoaJuridica { Nome = textBox1.Text, CNPJ = maskedTextBox1.Text };

            try
            {
                _consumidorDB.Adicionar(consumidor);
                MessageBox.Show("Consumidor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                MessageBox.Show("Erro ao salvar: O CPF ou CNPJ informado já existe no banco de dados.", "Documento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        

        /// Posiciona o cursor no início para facilitar a digitação.
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            // Move o cursor para o início do campo para facilitar a digitação.
            maskedTextBox1.Select(0, 0);
        }

        /// Garante que, ao trocar o tipo de pessoa, a máscara seja atualizada.
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
             // Apenas o RadioButton que ficou checado deve disparar a ação
            if (((RadioButton)sender).Checked)
            {
                AtualizarMascaraDocumento();
            }
        }

        private void AtualizarMascaraDocumento()
        {
            if (radioButton1.Checked) // Pessoa Física
            {
                label3.Text = "CPF:";
                maskedTextBox1.Mask = "000.000.000-00";
            }
            else // Pessoa Jurídica
            {
                label3.Text = "CNPJ:";
                maskedTextBox1.Mask = "00.000.000/0000-00";
            }
            // Limpa o texto anterior e posiciona o cursor no início.
            maskedTextBox1.Clear();
            maskedTextBox1.Select(0, 0);
        }

        private void LimparFormulario()
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            radioButton1.Checked = true;
            textBox1.Focus();
        }
    }
}
