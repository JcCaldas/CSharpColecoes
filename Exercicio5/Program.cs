Console.WriteLine("Exercício 5\n");

Console.WriteLine("Digite a quantidade de números que deseja criar:");
int numero = Convert.ToInt32(Console.ReadLine());

int[] arrayInteiros = new int[numero];

Random random = new Random();

for (int i = 0; i < arrayInteiros.Length; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(101);

    } while (arrayInteiros.Contains(numeroAleatorio));

    arrayInteiros[i] = numeroAleatorio;

}

Array.Sort(arrayInteiros);

Console.WriteLine("\nArray:");
foreach (int i in arrayInteiros)
{
    Console.Write($"{i} ");
}

while (true)
{

    Console.WriteLine("\nQual número gostaria de procurar no array (digite \"fim\" para interromper o programa):");
    var numProcura = Console.ReadLine();

    if (numProcura?.ToLower() == "fim")
        break;


    if (arrayInteiros.Contains(Convert.ToInt32(numProcura)))
    {
        for (int i = 0; i < arrayInteiros.Length; i++)
        {
            if (arrayInteiros[i] == Convert.ToInt32(numProcura))
                Console.WriteLine($"O número {numProcura} está no Array na posição {i}.");

        }
    }

    else
    {
        Console.WriteLine($"O número {numProcura} não existe no Array.");

    }

}