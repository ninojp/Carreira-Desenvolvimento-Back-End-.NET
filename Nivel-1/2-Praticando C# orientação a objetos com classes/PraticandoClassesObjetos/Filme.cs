using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class Filme
    {
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public Filme(string titulo, int classificacaoIndicativa)
        {
            Titulo = titulo;
            ClassificacaoIndicativa = classificacaoIndicativa;
        }
        public bool PodeAssistir(int idade)
        {
            return idade >= ClassificacaoIndicativa;
        }
        public void ExibirResultado(int idade)
        {
            if (PodeAssistir(idade))
            {
                Console.WriteLine($"Você pode assistir ao filme '{Titulo}'.");
            }
            else
            {
                Console.WriteLine($"Você não pode assistir ao filme '{Titulo}' devido à classificação indicativa.");
            }
        }
    }
}
