namespace WinFormsAppPraticar
{
    partial class Frm_Mascara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Msk_TextBox = new MaskedTextBox();
            Lbl_Conteudo = new Label();
            Lbl_Mascara_Ativa = new Label();
            Btn_Hora = new Button();
            Btn_Cep = new Button();
            Btn_Data = new Button();
            Btn_Senha = new Button();
            Btn_Moeda = new Button();
            Btn_Telefone = new Button();
            Btn_Conteudo = new Button();
            SuspendLayout();
            // 
            // Msk_TextBox
            // 
            Msk_TextBox.Location = new Point(68, 33);
            Msk_TextBox.Name = "Msk_TextBox";
            Msk_TextBox.Size = new Size(671, 47);
            Msk_TextBox.TabIndex = 1;
            Msk_TextBox.ValidatingType = typeof(DateTime);
            // 
            // Lbl_Conteudo
            // 
            Lbl_Conteudo.AutoSize = true;
            Lbl_Conteudo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Conteudo.Location = new Point(410, 185);
            Lbl_Conteudo.Name = "Lbl_Conteudo";
            Lbl_Conteudo.Size = new Size(0, 54);
            Lbl_Conteudo.TabIndex = 2;
            // 
            // Lbl_Mascara_Ativa
            // 
            Lbl_Mascara_Ativa.AutoSize = true;
            Lbl_Mascara_Ativa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Mascara_Ativa.Location = new Point(385, 109);
            Lbl_Mascara_Ativa.Name = "Lbl_Mascara_Ativa";
            Lbl_Mascara_Ativa.Size = new Size(0, 54);
            Lbl_Mascara_Ativa.TabIndex = 3;
            // 
            // Btn_Hora
            // 
            Btn_Hora.Location = new Point(68, 296);
            Btn_Hora.Name = "Btn_Hora";
            Btn_Hora.Size = new Size(188, 58);
            Btn_Hora.TabIndex = 4;
            Btn_Hora.Text = "Hora";
            Btn_Hora.UseVisualStyleBackColor = true;
            Btn_Hora.Click += Btn_Hora_Click;
            // 
            // Btn_Cep
            // 
            Btn_Cep.Location = new Point(68, 407);
            Btn_Cep.Name = "Btn_Cep";
            Btn_Cep.Size = new Size(188, 58);
            Btn_Cep.TabIndex = 5;
            Btn_Cep.Text = "CEP";
            Btn_Cep.UseVisualStyleBackColor = true;
            Btn_Cep.Click += Btn_Cep_Click;
            // 
            // Btn_Data
            // 
            Btn_Data.Location = new Point(305, 296);
            Btn_Data.Name = "Btn_Data";
            Btn_Data.Size = new Size(188, 58);
            Btn_Data.TabIndex = 6;
            Btn_Data.Text = "Data";
            Btn_Data.UseVisualStyleBackColor = true;
            Btn_Data.Click += Btn_Data_Click;
            // 
            // Btn_Senha
            // 
            Btn_Senha.Location = new Point(318, 397);
            Btn_Senha.Name = "Btn_Senha";
            Btn_Senha.Size = new Size(188, 58);
            Btn_Senha.TabIndex = 7;
            Btn_Senha.Text = "Senha";
            Btn_Senha.UseVisualStyleBackColor = true;
            Btn_Senha.Click += Btn_Senha_Click;
            // 
            // Btn_Moeda
            // 
            Btn_Moeda.Location = new Point(551, 296);
            Btn_Moeda.Name = "Btn_Moeda";
            Btn_Moeda.Size = new Size(188, 58);
            Btn_Moeda.TabIndex = 8;
            Btn_Moeda.Text = "Moeda";
            Btn_Moeda.UseVisualStyleBackColor = true;
            Btn_Moeda.Click += Btn_Moeda_Click;
            // 
            // Btn_Telefone
            // 
            Btn_Telefone.Location = new Point(551, 407);
            Btn_Telefone.Name = "Btn_Telefone";
            Btn_Telefone.Size = new Size(188, 58);
            Btn_Telefone.TabIndex = 9;
            Btn_Telefone.Text = "Telefone";
            Btn_Telefone.UseVisualStyleBackColor = true;
            Btn_Telefone.Click += Btn_Telefone_Click;
            // 
            // Btn_Conteudo
            // 
            Btn_Conteudo.Location = new Point(68, 507);
            Btn_Conteudo.Name = "Btn_Conteudo";
            Btn_Conteudo.Size = new Size(627, 58);
            Btn_Conteudo.TabIndex = 10;
            Btn_Conteudo.Text = "Ver Conteudo";
            Btn_Conteudo.UseVisualStyleBackColor = true;
            Btn_Conteudo.Click += Btn_Conteudo_Click;
            // 
            // Frm_Mascara
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(Btn_Conteudo);
            Controls.Add(Btn_Telefone);
            Controls.Add(Btn_Moeda);
            Controls.Add(Btn_Senha);
            Controls.Add(Btn_Data);
            Controls.Add(Btn_Cep);
            Controls.Add(Btn_Hora);
            Controls.Add(Lbl_Mascara_Ativa);
            Controls.Add(Lbl_Conteudo);
            Controls.Add(Msk_TextBox);
            Name = "Frm_Mascara";
            Text = "Formulario Mascara";
            TopMost = true;
            Load += Frm_Mascara_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox Msk_TextBox;
        private Label Lbl_Conteudo;
        private Label Lbl_Mascara_Ativa;
        private Button Btn_Hora;
        private Button Btn_Cep;
        private Button Btn_Data;
        private Button Btn_Senha;
        private Button Btn_Moeda;
        private Button Btn_Telefone;
        private Button Btn_Conteudo;
    }
}