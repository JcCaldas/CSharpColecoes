public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }

    public static void ExibirLista ( List<Produto> produtos)
    {
        decimal soma = 0, media = 0;

        Console.WriteLine("Lista de Produtos:\n");

        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco.ToString("c")}\n");
            soma += produto.Preco;
        }
        Console.WriteLine($"Quantidade: {produtos.Count}");
        Console.WriteLine($"Soma: {soma.ToString("c")}");
        media = soma / produtos.Count;
        Console.WriteLine($"Média: {media.ToString("c")}\n");
    }
}