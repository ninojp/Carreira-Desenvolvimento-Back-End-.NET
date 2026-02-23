using System;
using System.Collections.Generic;
using System.Text;

namespace VideoFlix.PlataformaB
{
    internal class Video
    {
        public string NomePlataforma { get; set; }
        public Video(string nomePlataforma)
        {
            NomePlataforma = nomePlataforma;
        }
    }
}
