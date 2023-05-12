Console.WriteLine("Exercício 6\n");

float[,] notasAlunos = new float[5, 2];
float[] grupo1 = new float[5];
float[] grupo2 = new float[5];
float soma = 0, media;

for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 2; j++)
    {
        if (j == 0)
            Console.WriteLine("Grupo 1");

        else
            Console.WriteLine("Grupo 2");

        Console.WriteLine($"Digite a nota do {i + 1}º aluno do grupo: ");
        notasAlunos[i, j] = (float)Convert.ToDouble(Console.ReadLine());
    }
}

Console.WriteLine("\nGrupo 1\tGrupo 2\n");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"{notasAlunos[i, j]}\t");
    }
}



for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (j == 0)
            grupo1[i] = notasAlunos[i, j];

        else
            grupo2[i] = notasAlunos[i, j];
    }
}

foreach (float nota in  grupo1)
{
    soma += nota;
}

media = soma / grupo1.Length;
Console.WriteLine($"\nMédia Grupo 1: {media.ToString("F2")}");

soma = 0;
foreach (float nota in grupo2)
{
    soma += nota;
}

media = soma / grupo1.Length;
Console.WriteLine($"\nMédia Grupo 2: {media.ToString("F2")}");
