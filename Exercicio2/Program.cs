Console.WriteLine("Exercício 2 - Array Bidimensional\n");

Console.WriteLine("\nAtribuindo dados a um array de " +
                    "strings com 2 linhas e 5 colunas [2,5]\n");

Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");
Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}\n");


//Declaração e alocação de memória para o array
string[,] alunos = new string[2, 5];

//Laço for para receber os nomes nas posições [linha (i), coluna (j)]
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o nome para a linha {i}, coluna {j} [{i},{j}]: ");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteúdo do Array alunos:\n");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        
        Console.Write($"[{i}, {j}] - {alunos[i,j]}\t");
    }
    Console.WriteLine();
}


Console.ReadKey();