using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class Passagem
    {
        public string Passageiro { get; set; }
        public string Destino { get; set; }
        public Passagem(string passageiro, string destino)
        {
            Passageiro = passageiro;
            Destino = destino;
        }
    }
}
