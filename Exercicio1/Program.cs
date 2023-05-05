Console.WriteLine("Exercício 1 - Arrays unidimensionais\n");

string[] nomes = new string[5];
double[] notas = new double[5];
double media;
double soma = 0.0;

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"\nDigite o nome do {i + 1}º aluno:");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Digite a nota do aluno(a) {nomes[i]}:");
    notas[i] = Convert.ToDouble(Console.ReadLine());
    soma += notas[i];

}

media = soma / notas.Count();//Count() retorna o número de elementos do array

Console.Write("\nNomes: ");
foreach (var nome in nomes)
{
    Console.Write($"{nome} ");
}

Console.Write("\nNotas: ");
foreach (var nota  in notas)
{
    Console.Write($"{nota} ");
}

Console.WriteLine($"\nMédia: {media}");


Console.ReadKey();