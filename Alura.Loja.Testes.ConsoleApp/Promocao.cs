using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        // Inserindo propriedade Produtos para indicar relacionamento de muitos para muitos com a tabela de Produtos
        public IList<PromocaoProduto> Produtos { get; internal set; }

        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        internal void IncluiProduto(Produto produto)
        {
            this.Produtos.Add(new PromocaoProduto() { Produto = produto });
        }
    }
}
