using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class InformacaoTecnica
    {
        public int TamanhoMB { get; set; }
        public string SistemaOperacional { get; set; }
        public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
        {
            TamanhoMB = tamanhoMB;
            SistemaOperacional = sistemaOperacional;
        }
    }
}
