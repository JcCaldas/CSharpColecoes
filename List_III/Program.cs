Console.WriteLine("## List III - Find ##\n");

List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

/*Retorna o primeiro elemento que corresponde ao predicado
 fornecido. Predicado é um método ou função que retorna um
valor bool.*/

var frutas1 = frutas.Find(Procura);
Console.WriteLine($"Predicado -> {frutas1}");

/*Pode-se ultilizar uma expressão lâmbida (=>) no lugar de 
 definir uma função.
Ex: x => x*x -> Define um parâmetro chamado "x" e retorna o valor de "x * x"
*/

var frutas2 = frutas.Find(f => f.Contains("n"));
Console.WriteLine($"\nFind: Expressão Lâmbida -> {frutas2}");

//Retorna o último elemento
var frutas3 = frutas.FindLast(f => f.Contains("n"));
Console.WriteLine($"\nFindLast: Expressão Lâmbida -> {frutas3}");

//Retorna o primeiro índice
var frutas4 = frutas.FindIndex(f => f.Contains("n"));
Console.WriteLine($"\nFindIndex: Expressão Lâmbida -> índice[{frutas4}] Item = {frutas[frutas4]}");

//Retorna o ultimo índice
var frutas5 = frutas.FindLastIndex(f => f.Contains("n"));
Console.WriteLine($"\nFindLastIndex: Expressão Lâmbida -> índice[{frutas5}] Item = {frutas[frutas5]}");

//Retorna todos os itens (em forma de lista)
var frutas6 = frutas.FindAll(f => f.Contains("n"));
Console.WriteLine($"\nFindAll: Expressão Lâmbida");

foreach (var item in frutas6)
{
    Console.Write($"{item} ");
}

Console.ReadKey();

//Predicado
static bool Procura (string item)
{
    return item.Contains("n");//retorna o item q contem.
    //return item.StartsWith("L"); //retorna o item q começa com...
}