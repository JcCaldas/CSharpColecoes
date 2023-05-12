using System.Collections;

Console.WriteLine("Exercício 7\n");
string? nome;
int idade;

ArrayList listaPessoas = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Pessoa pessoas = new Pessoa();

    Console.Write($"\nDigite o nome da {i + 1}ª pessoa: ");
    nome = Console.ReadLine();

    Console.Write($"\nDigite a idade da {i + 1}ª pessoa: ");
    idade = Convert.ToInt32(Console.ReadLine());

    pessoas.Nome = nome;
    pessoas.Idade = idade;
    listaPessoas.Add(pessoas);

}

ExibirLista(listaPessoas);

Console.WriteLine("\nAdicionando Jaime e Tânia");
listaPessoas.Add(new Pessoa() {Nome = "Jaime", Idade = 20 });
listaPessoas.Add(new Pessoa() {Nome = "Tânia", Idade = 18 });
ExibirLista(listaPessoas);

Console.WriteLine("\nDeletando o último elemento.");
listaPessoas.RemoveAt(listaPessoas.Count -1);
ExibirLista(listaPessoas);

Console.ReadKey();

static void ExibirLista(ArrayList listaPessoas)
{
    Console.WriteLine("\nLista:");
    foreach (Pessoa pessoa in listaPessoas)
    {
        Console.WriteLine();
        pessoa.Exibir(pessoa.Nome, pessoa.Idade);
    }
}

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public void Exibir(string? nome, int idade)
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }

}