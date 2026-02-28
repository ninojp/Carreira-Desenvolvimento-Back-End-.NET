using System;
using System.Collections.Generic;
using System.Text;

namespace AluraDesafios.Aula4Exercicio.RegistroDeAcesso.Relatorios
{
    internal class AcessoAoPredio
    {
        public AcessoAoPredio(DateTime entrada, string resumo)
        {
            Entrada = entrada;
            Resumo = resumo;
        }

        public DateTime Entrada { get; }
        public string Resumo { get; }
    }
}
