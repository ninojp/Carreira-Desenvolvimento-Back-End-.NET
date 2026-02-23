using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class Retangulo
    {
        public int Altura { get; set; }
        public int Largura { get; set; }

        public Retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public int CalcularArea()
        {
            return Altura * Largura;
        }
    }
}