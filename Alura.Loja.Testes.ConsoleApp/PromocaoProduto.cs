using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    //Classe para criação de tabela de join para representar relacionamento de muitos para muitos entre as classes Promocao e Produto
    public class PromocaoProduto
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PromocaoId { get; set; }
        public Promocao Promocao { get; set; }
    }
}
