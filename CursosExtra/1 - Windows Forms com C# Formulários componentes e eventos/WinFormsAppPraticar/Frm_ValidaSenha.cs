using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsAppPraticar;

public partial class Frm_ValidaSenha : Form
{
    bool senhaVisivel = false;
    public Frm_ValidaSenha()
    {
        InitializeComponent();
    }

    private void Btn_Reset_Click(object sender, EventArgs e)
    {
        Txt_Senha.Text = "";
        Lbl_Resultado.Text = "";
    }

    private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
    {
        ChecaForcaSenha checaForcaSenha = new ChecaForcaSenha();
        ChecaForcaSenha.ForcaDaSenha forcaDaSenha = checaForcaSenha.GetForcaDaSenha(Txt_Senha.Text);
        Lbl_Resultado.Text = forcaDaSenha.ToString();
        if(Lbl_Resultado.Text == "Inaceitavel")
        {
            Lbl_Resultado.ForeColor = Color.Red;
        }
        else if(Lbl_Resultado.Text == "Fraca")
        {
            Lbl_Resultado.ForeColor = Color.Orange;
        }
        else if(Lbl_Resultado.Text == "Aceitavel")
        {
            Lbl_Resultado.ForeColor = Color.Yellow;
        }
        else if(Lbl_Resultado.Text == "Forte")
        {
            Lbl_Resultado.ForeColor = Color.Green;
        }
        else if(Lbl_Resultado.Text == "Segura")
        {
            Lbl_Resultado.ForeColor = Color.Blue;
        }
    }

    private void Btn_Exibir_Senha_Click(object sender, EventArgs e)
    {
        if(senhaVisivel)
        {
            Txt_Senha.PasswordChar = '*';
            senhaVisivel = false;
            Btn_Exibir_Senha.Text = "Exibir Senha";
        }
        else
        {
            Txt_Senha.PasswordChar = '\0';
            senhaVisivel = true;
            Btn_Exibir_Senha.Text = "Ocultar Senha";
        }
    }
}

public class ChecaForcaSenha
{
    public enum ForcaDaSenha
    {
        Inaceitavel,
        Fraca,
        Aceitavel,
        Forte,
        Segura
    }
    public int geraPontosSenha(string senha)
    {
        if (senha == null) return 0;
        int pontosPorTamanho = GetPontoPorTamanho(senha);
        int pontosPorMinusculas = GetPontoPorMinusculas(senha);
        int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
        int pontosPorDigitos = GetPontoPorDigitos(senha);
        int pontosPorSimbolos = GetPontoPorSimbolos(senha);
        int pontosPorRepeticao = GetPontoPorRepeticao(senha);
        return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
    }
    private int GetPontoPorTamanho(string senha)
    {
        return Math.Min(10, senha.Length) * 7;
    }
    private int GetPontoPorMinusculas(string senha)
    {
        int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
        return Math.Min(2, rawplacar) * 5;
    }
    private int GetPontoPorMaiusculas(string senha)
    {
        int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
        return Math.Min(2, rawplacar) * 5;
    }
    private int GetPontoPorDigitos(string senha)
    {
        int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
        return Math.Min(2, rawplacar) * 6;
    }
    private int GetPontoPorSimbolos(string senha)
    {
        int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
        return Math.Min(2, rawplacar) * 5;
    }
    private int GetPontoPorRepeticao(string senha)
    {
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
        bool repete = regex.IsMatch(senha);
        if (repete) return 30;
        else return 0;
    }
    public ForcaDaSenha GetForcaDaSenha(string senha)
    {
        int placar = geraPontosSenha(senha);
        if (placar < 50) return ForcaDaSenha.Inaceitavel;
        else if (placar < 60) return ForcaDaSenha.Fraca;
        else if (placar < 80) return ForcaDaSenha.Aceitavel;
        else if (placar < 100) return ForcaDaSenha.Forte;
        else return ForcaDaSenha.Segura;
    }
}