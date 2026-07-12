namespace WinFormsAppPraticar
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }
        private void Txt_Input_KeyDown_1(object sender, KeyEventArgs e)
        {
            //Txt_Msg.AppendText($"\r\n" + "Precione uma tecla..." + "\r\n");
            Txt_Msg.AppendText($"Tecla precionada: {e.KeyCode} -> Valor ASCII: {(int)e.KeyCode} {Environment.NewLine}");
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
        }

        private void Btn_Reset_Click_1(object sender, EventArgs e)
        {
            Txt_Msg.Clear();
            Txt_Input.Clear();
            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
        }
    }
}
