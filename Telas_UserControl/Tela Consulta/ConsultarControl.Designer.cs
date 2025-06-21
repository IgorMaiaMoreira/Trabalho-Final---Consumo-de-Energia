namespace ContaDeLuz.Telas_UserControl
{
    partial class ConsultarControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnVerDetalhes = new Button();
            btnVoltar_Consulta = new Button();
            Column4 = new DataGridViewTextBoxColumn();
            Consumo = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            colInstalacao = new DataGridViewTextBoxColumn();
            dvgContas = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgContas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 25);
            label1.Name = "label1";
            label1.Size = new Size(284, 30);
            label1.TabIndex = 1;
            label1.Text = "Consulta de Cliente ou Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 91);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF/CNPJ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(496, 87);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = " 🔍 Buscar ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 140);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome / Razão Social:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 184);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo de Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 140);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 7;
            label5.Text = "{nome}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 184);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "{tipo}";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dvgContas);
            groupBox1.Location = new Point(54, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 167);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contas Associadas";
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.Location = new Point(252, 396);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(95, 40);
            btnVerDetalhes.TabIndex = 10;
            btnVerDetalhes.Text = "Ver Detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnVoltar_Consulta
            // 
            btnVoltar_Consulta.Location = new Point(441, 396);
            btnVoltar_Consulta.Name = "btnVoltar_Consulta";
            btnVoltar_Consulta.Size = new Size(95, 40);
            btnVoltar_Consulta.TabIndex = 11;
            btnVoltar_Consulta.Text = "Voltar";
            btnVoltar_Consulta.UseVisualStyleBackColor = true;
            btnVoltar_Consulta.Click += btnVoltar_Click;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor Total";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Consumo
            // 
            Consumo.HeaderText = "Consumo";
            Consumo.Name = "Consumo";
            Consumo.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // colInstalacao
            // 
            colInstalacao.HeaderText = "Nº da Instalação";
            colInstalacao.Name = "colInstalacao";
            colInstalacao.ReadOnly = true;
            // 
            // dvgContas
            // 
            dvgContas.AllowUserToAddRows = false;
            dvgContas.AllowUserToDeleteRows = false;
            dvgContas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgContas.Columns.AddRange(new DataGridViewColumn[] { colInstalacao, Column2, Consumo, Column4 });
            dvgContas.Location = new Point(104, 22);
            dvgContas.Name = "dvgContas";
            dvgContas.ReadOnly = true;
            dvgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgContas.Size = new Size(476, 127);
            dvgContas.TabIndex = 0;
            dvgContas.CellContentClick += dvgContas_CellContentClick;
            // 
            // ConsultarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVoltar_Consulta);
            Controls.Add(btnVerDetalhes);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarControl";
            Size = new Size(800, 450);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgContas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnVerDetalhes;
        private Button btnVoltar_Consulta;
        private DataGridView dvgContas;
        private DataGridViewTextBoxColumn colInstalacao;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Consumo;
        private DataGridViewTextBoxColumn Column4;
    }
}
