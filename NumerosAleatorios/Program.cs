Console.WriteLine("## Números Aleatórios - Classe Random ##\n");

//utiliza a semente padrão (relógio do sistema)
Random random = new Random();
//utiliza a semente que defini (2023, no caso)
Random random2 = new Random(2023);

//Número gerado no intervalos dos números inteiros
Console.WriteLine(random.Next());
Console.WriteLine(random2.Next());
Console.WriteLine();

//Gera um número entre 0 e o valor máximo definido, sem incluir
Console.WriteLine(random.Next(20));
Console.WriteLine(random2.Next(20));
Console.WriteLine();

//Gera um número entre o mínimo informado e o máximo, sem incluir o máximo.
Console.WriteLine(random.Next(10, 20));
Console.WriteLine(random2.Next(10, 20));
Console.WriteLine();

//Gera números aleatórios entre 0.0 e 1.0.
Console.WriteLine(random.NextDouble());
Console.WriteLine(random2.NextDouble());
Console.WriteLine();

//Geração de números aleatórios por laço for
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(random.Next());
    Console.WriteLine(random2.Next());
}
Console.WriteLine();

//preenche com os números aleatórios entre 0 e 255.
byte[] randBytes = new byte[10];
random2.NextBytes(randBytes);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(randBytes[i]);
}

Console.WriteLine("\nSimulando sorteio de loteria:");

Random random1 = new Random();
int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random1.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados:\n");

/*Concatena os elementos de um array especificado ou
 os membros de uma coleção, usando o separados específico
 entre cada elemento ou membro.*/
Console.WriteLine(string.Join(" ", numerosSorteados));

Console.ReadKey();