namespace WinFormsAppPraticar
{
    partial class Frm_DemonstracaoKey
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            Txt_Input = new TextBox();
            Txt_Msg = new TextBox();
            Btn_Reset = new Button();
            Lbl_Maius = new Label();
            Lbl_Upper = new Label();
            Lbl_Minus = new Label();
            Lbl_Lower = new Label();
            SuspendLayout();
            // 
            // Txt_Input
            // 
            Txt_Input.BackColor = SystemColors.ActiveCaption;
            Txt_Input.Location = new Point(294, 26);
            Txt_Input.Multiline = true;
            Txt_Input.Name = "Txt_Input";
            Txt_Input.Size = new Size(150, 72);
            Txt_Input.TabIndex = 1;
            Txt_Input.KeyDown += Txt_Input_KeyDown_1;
            // 
            // Txt_Msg
            // 
            Txt_Msg.BackColor = SystemColors.ActiveCaption;
            Txt_Msg.Location = new Point(31, 121);
            Txt_Msg.Multiline = true;
            Txt_Msg.Name = "Txt_Msg";
            Txt_Msg.ScrollBars = ScrollBars.Vertical;
            Txt_Msg.Size = new Size(685, 699);
            Txt_Msg.TabIndex = 2;
            Txt_Msg.TabStop = false;
            // 
            // Btn_Reset
            // 
            Btn_Reset.BackColor = SystemColors.ActiveCaption;
            Btn_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Reset.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Reset.Location = new Point(921, 26);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(193, 64);
            Btn_Reset.TabIndex = 3;
            Btn_Reset.Text = "Limpar";
            Btn_Reset.UseVisualStyleBackColor = false;
            Btn_Reset.Click += Btn_Reset_Click_1;
            // 
            // Lbl_Maius
            // 
            Lbl_Maius.BackColor = SystemColors.ActiveCaptionText;
            Lbl_Maius.Font = new Font("Arial Black", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Maius.ForeColor = SystemColors.ActiveCaption;
            Lbl_Maius.Location = new Point(831, 189);
            Lbl_Maius.Name = "Lbl_Maius";
            Lbl_Maius.Size = new Size(380, 92);
            Lbl_Maius.TabIndex = 5;
            Lbl_Maius.Text = "Maiúsculas";
            // 
            // Lbl_Upper
            // 
            Lbl_Upper.BackColor = SystemColors.ActiveCaption;
            Lbl_Upper.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Upper.Location = new Point(853, 281);
            Lbl_Upper.Name = "Lbl_Upper";
            Lbl_Upper.Size = new Size(322, 76);
            Lbl_Upper.TabIndex = 6;
            // 
            // Lbl_Minus
            // 
            Lbl_Minus.BackColor = SystemColors.ActiveCaptionText;
            Lbl_Minus.Font = new Font("Arial Black", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Minus.ForeColor = SystemColors.ActiveCaption;
            Lbl_Minus.Location = new Point(831, 513);
            Lbl_Minus.Name = "Lbl_Minus";
            Lbl_Minus.Size = new Size(376, 87);
            Lbl_Minus.TabIndex = 7;
            Lbl_Minus.Text = "Minúsculas";
            // 
            // Lbl_Lower
            // 
            Lbl_Lower.BackColor = SystemColors.ActiveCaption;
            Lbl_Lower.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Lower.Location = new Point(853, 616);
            Lbl_Lower.Name = "Lbl_Lower";
            Lbl_Lower.Size = new Size(322, 76);
            Lbl_Lower.TabIndex = 8;
            // 
            // Frm_DemonstracaoKey
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1309, 845);
            Controls.Add(Lbl_Lower);
            Controls.Add(Lbl_Minus);
            Controls.Add(Lbl_Upper);
            Controls.Add(Lbl_Maius);
            Controls.Add(Btn_Reset);
            Controls.Add(Txt_Msg);
            Controls.Add(Txt_Input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_DemonstracaoKey";
            Text = "Form Demonstração Event Key";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Input;
        private TextBox Txt_Msg;
        private Button Btn_Reset;
        private Label Lbl_Maius;
        private Label Lbl_Upper;
        private Label Lbl_Minus;
        private Label Lbl_Lower;
    }
}
