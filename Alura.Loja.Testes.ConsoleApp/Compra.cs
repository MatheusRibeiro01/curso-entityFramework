namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        //Id representa chave primaria da tabela
        public int Id { get; set; }
        public int Quantidade { get; internal set; }

        //Explicitando a chave estrangeira para que a coluna ProdutoId não aceite valor nulo na hora de realizar a migration
        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }
    }
}