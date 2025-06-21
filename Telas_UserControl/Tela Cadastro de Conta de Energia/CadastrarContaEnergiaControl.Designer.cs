namespace ContaDeLuz.Telas_UserControl
{
    partial class CadastrarContaEnergiaControl
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
            btnBuscar = new Button();
            label3 = new Label();
            grpDados = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label13 = new Label();
            btnCalcular = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            grpDados.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Conta de Energia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 95);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 1;
            label2.Text = "Consumidor (CPF/CNPJ):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(488, 95);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 130);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // grpDados
            // 
            grpDados.Controls.Add(label10);
            grpDados.Controls.Add(label9);
            grpDados.Controls.Add(textBox4);
            grpDados.Controls.Add(textBox3);
            grpDados.Controls.Add(textBox2);
            grpDados.Controls.Add(label8);
            grpDados.Controls.Add(label7);
            grpDados.Controls.Add(label6);
            grpDados.Controls.Add(radioButton2);
            grpDados.Controls.Add(radioButton1);
            grpDados.Controls.Add(label5);
            grpDados.Location = new Point(36, 150);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(735, 160);
            grpDados.TabIndex = 5;
            grpDados.TabStop = false;
            grpDados.Text = "Dados da conta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 119);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 9;
            label10.Text = "kWh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(402, 89);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 7;
            label9.Text = "kWh";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(281, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(281, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 119);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 5;
            label8.Text = "Leitura Atual:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 89);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 4;
            label7.Text = "Leitura Anterior:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 61);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 3;
            label6.Text = "Nº da Instalação:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(405, 19);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Comercial";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(281, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Residencial";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(95, 19);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 0;
            label5.Text = "Tipo de Conta:";
            label5.Click += label5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(133, 323);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 7;
            label11.Text = "Consumo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(133, 354);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 8;
            label12.Text = "Valor da Conta:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(317, 315);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(317, 346);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(438, 323);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 11;
            label13.Text = "kWh";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(226, 396);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 39);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(351, 396);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 39);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(477, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 39);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 130);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 15;
            label4.Text = "{nome}";
            // 
            // CadastrarContaEnergiaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCalcular);
            Controls.Add(label13);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(grpDados);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarContaEnergiaControl";
            Size = new Size(800, 450);
            Load += CadastrarContaEnergiaControl_Load;
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnBuscar;
        private Label label3;
        private GroupBox grpDados;
        private Label label5;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label11;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label13;
        private Button btnCalcular;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label4;
    }
}
