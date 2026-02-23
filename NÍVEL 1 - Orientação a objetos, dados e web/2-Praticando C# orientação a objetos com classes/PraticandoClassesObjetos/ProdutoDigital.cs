using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class ProdutoDigital
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public InformacaoTecnica InformacaoTecnica { get; set; }
        public ProdutoDigital(string nome, decimal preco, InformacaoTecnica informacaoTecnica)
        {
            Nome = nome;
            Preco = preco;
            InformacaoTecnica = informacaoTecnica;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("Produto: " + Nome);
            Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
            Console.WriteLine("Tamanho: " + InformacaoTecnica.TamanhoMB + "MB");
            Console.WriteLine("Compatível com: " + InformacaoTecnica.SistemaOperacional);
        }
    }
}
