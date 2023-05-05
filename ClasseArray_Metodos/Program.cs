Console.WriteLine("## Classe Array - Métodos mais ultilizados ##\n");

string[] nomes = { "Ana", "Maria", "João", "José", "Paulo", "Beatriz", "Carol" };

Console.WriteLine("Exibindo o array original...");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array...");
Array.Reverse(nomes);//Inverte o array na memória
ExibeArray(nomes);

Console.WriteLine("\n\nOrdena o array...");
Array.Sort(nomes); //Ordena o array na ordem crescente, se for string, será na ordem alfabética
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array...");
Console.WriteLine("Informe o nome:");
string resposta = Console.ReadLine();
var indice = Array.BinarySearch(nomes, resposta);//Retorna o índice do elemento no array. Se for negativo, ele não encontrou

if (indice >= 0)
    Console.WriteLine($"\n{resposta} foi encontrado no ínidice {indice}");
else
    Console.WriteLine($"\n{resposta} não foi encontrado no array.");
Console.ReadKey();

/*Essa função foi feita, pois ultilizarei esse código
 * várias vezes durante o estudo.
 * Para que essa função seja feita de forma automática
 * deve-se escrever o código no programa, selecionar e
 * após isso clicar na chave de fenda e clicar em 
 * "Extrair a função local"*/
static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome} ");
    }
}