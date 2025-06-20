namespace ContaDeLuz.Telas_UserControl
{
    partial class CadastrarConsumidorControl
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
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            btnSalvarConsumidor = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 58);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Consumidor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(0, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(816, 124);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Consumidor:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(200, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoa Física";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(475, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pessoa Jurídica";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(375, 345);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(232, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 302);
            label2.Name = "label2";
            label2.Size = new Size(134, 17);
            label2.TabIndex = 4;
            label2.Text = "Nome / Razão Social:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 346);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 5;
            label3.Text = "CPF / CNPJ:";
            // 
            // btnSalvarConsumidor
            // 
            btnSalvarConsumidor.Location = new Point(284, 420);
            btnSalvarConsumidor.Name = "btnSalvarConsumidor";
            btnSalvarConsumidor.Size = new Size(84, 39);
            btnSalvarConsumidor.TabIndex = 6;
            btnSalvarConsumidor.Text = "Salvar";
            btnSalvarConsumidor.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 39);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastrarConsumidorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvarConsumidor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CadastrarConsumidorControl";
            Size = new Size(816, 489);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label3;
        private Button btnSalvarConsumidor;
        private Button btnCancelar;
    }
}
