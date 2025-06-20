namespace ContaDeLuz.Telas_UserControl
{
    partial class MenuPrincipalControl
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
            btnCadastrarConsumidor = new Button();
            btnCadastrarConta = new Button();
            btnConsultar = new Button();
            BtnRelatorios = new Button();
            btnSalvar = new Button();
            btnCarregar = new Button();
            btnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCadastrarConsumidor
            // 
            btnCadastrarConsumidor.Location = new Point(290, 166);
            btnCadastrarConsumidor.Name = "btnCadastrarConsumidor";
            btnCadastrarConsumidor.Size = new Size(201, 23);
            btnCadastrarConsumidor.TabIndex = 0;
            btnCadastrarConsumidor.Text = "Cadastrar Consumidor";
            btnCadastrarConsumidor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarConta
            // 
            btnCadastrarConta.Location = new Point(290, 195);
            btnCadastrarConta.Name = "btnCadastrarConta";
            btnCadastrarConta.Size = new Size(201, 23);
            btnCadastrarConta.TabIndex = 1;
            btnCadastrarConta.Text = "Cadastrar Conta de Energia";
            btnCadastrarConta.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(290, 224);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(201, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar Cliente ou Conta";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnRelatorios
            // 
            BtnRelatorios.Location = new Point(290, 253);
            BtnRelatorios.Name = "BtnRelatorios";
            BtnRelatorios.Size = new Size(201, 23);
            BtnRelatorios.TabIndex = 3;
            BtnRelatorios.Text = "Relatórios";
            BtnRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(290, 282);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(201, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar Dados";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(290, 311);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(201, 23);
            btnCarregar.TabIndex = 5;
            btnCarregar.Text = "Carregar Dados";
            btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(290, 340);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(201, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 111);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 7;
            label1.Text = "Conta de Luz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 415);
            label2.Name = "label2";
            label2.Size = new Size(277, 15);
            label2.TabIndex = 8;
            label2.Text = "Made by: Igor Maia, Victor Schneider, Luis Sampaio";
            // 
            // MenuPrincipalControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(btnCarregar);
            Controls.Add(btnSalvar);
            Controls.Add(BtnRelatorios);
            Controls.Add(btnConsultar);
            Controls.Add(btnCadastrarConta);
            Controls.Add(btnCadastrarConsumidor);
            Name = "MenuPrincipalControl";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarConsumidor;
        private Button btnCadastrarConta;
        private Button btnConsultar;
        private Button BtnRelatorios;
        private Button btnSalvar;
        private Button btnCarregar;
        private Button btnSair;
        private Label label1;
        private Label label2;
    }
}
