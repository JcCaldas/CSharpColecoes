using System;

Console.WriteLine("Exercício 4\n");

string[] frutas = new string[] { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

Console.WriteLine("Exibindo itens do array:");
Console.WriteLine("Laço For:\n");

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}

Console.WriteLine("\nLaço Foreach:\n");

ExibeArray(frutas);

Console.WriteLine($"\nQuantidade de itens: {frutas.Length}\n");

Console.WriteLine("Exibindo nome do segundo e penúltimo item do array:\n");
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[8]);

Console.WriteLine("\nAlterando nome da 3ª fruta para \"Kiwi\" e da última para \"Caqui\"\n");
frutas[2] = frutas[2].Replace("Laranja", "Kiwi");
frutas[9] = frutas[9].Replace("Amora", "Caqui");

ExibeArray(frutas);

Console.WriteLine("\nOrdenando, em ordem crescente, o Array:");

Array.Sort(frutas);

ExibeArray(frutas);

Console.WriteLine("\nOrdem inversa do Array:");

Array.Reverse(frutas);

ExibeArray(frutas);


Console.ReadKey();

static void ExibeArray(string[] frutas)
{
    foreach (string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
}