namespace GerenciadorDePecas.Negocios
{
    public class Peca
    {
        public int Id { get; set; } // ID da peça (será gerado automaticamente pelo banco de dados)
        public string Nome { get; set; } // Nome da peça
        public string Fabricante { get; set; } // Fabricante da peça
        public decimal PrecoCompra { get; set; } // Preço de compra da peça
        public decimal PrecoVenda { get; set; } // Preço de venda da peça
        public string Status { get; set; } // Status da peça (ex: "ativo", "vendido", "excluída")

        // Construtor padrão
        public Peca() { }

        // Construtor com parâmetros para facilitar o preenchimento
        public Peca(string nome, string fabricante, decimal precoCompra, decimal precoVenda, string status)
        {
            Nome = nome;
            Fabricante = fabricante;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            Status = status;
        }
    }
}

