Console.WriteLine("Exercício 8\n");

List<Produto> produtos = new List<Produto>() 
{
    new Produto() {Nome = "Clips", Preco = 3.95M},
    new Produto() {Nome = "Caneta", Preco = 5.99M},
    new Produto() {Nome = "Lápis", Preco = 4.15M},
    new Produto() {Nome = "Estojo", Preco = 6.99M},
    new Produto() {Nome = "Caderno", Preco = 7.55M}

};

Produto.ExibirLista(produtos);

produtos.Add(new Produto() { Nome = "Mochila", Preco = 22.44M });

Produto.ExibirLista(produtos);

var listaOrdenada =  produtos.OrderBy (produtos => produtos.Nome).ToList();

Produto.ExibirLista(listaOrdenada);

Console.WriteLine("Produtos com valores inferiores a R$5,00:\n");
for (int i = 0; i < listaOrdenada.Count; i++)
{
    if (listaOrdenada[i].Preco < 5)
    {
        Console.WriteLine($"Produto: {listaOrdenada[i].Nome}");
        Console.WriteLine($"Preço: {listaOrdenada[i].Preco.ToString("c")}\n");
    }
}

//Falta Localiza o item "estojo" na lista