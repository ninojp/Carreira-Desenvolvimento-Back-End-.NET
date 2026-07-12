namespace WinFormsAppPraticar
{
    partial class Frm_ValidaSenha
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
            Txt_Senha = new TextBox();
            Lbl_Resultado = new Label();
            Btn_Reset = new Button();
            Btn_Exibir_Senha = new Button();
            SuspendLayout();
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(44, 63);
            Txt_Senha.Multiline = true;
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(403, 58);
            Txt_Senha.TabIndex = 0;
            Txt_Senha.KeyDown += Txt_Senha_KeyDown;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.Font = new Font("Segoe UI Black", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Resultado.ForeColor = SystemColors.ActiveCaption;
            Lbl_Resultado.Location = new Point(44, 207);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(403, 102);
            Lbl_Resultado.TabIndex = 1;
            Lbl_Resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(560, 63);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(188, 58);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpar";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_Exibir_Senha
            // 
            Btn_Exibir_Senha.Location = new Point(478, 181);
            Btn_Exibir_Senha.Name = "Btn_Exibir_Senha";
            Btn_Exibir_Senha.Size = new Size(270, 58);
            Btn_Exibir_Senha.TabIndex = 4;
            Btn_Exibir_Senha.Text = "Exibir Senha";
            Btn_Exibir_Senha.UseVisualStyleBackColor = true;
            Btn_Exibir_Senha.Click += Btn_Exibir_Senha_Click;
            // 
            // Frm_ValidaSenha
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Exibir_Senha);
            Controls.Add(Btn_Reset);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Txt_Senha);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Frm_ValidaSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Valida Senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Senha;
        private Label Lbl_Resultado;
        private Button Btn_Reset;
        private Button Btn_Exibir_Senha;
    }
}