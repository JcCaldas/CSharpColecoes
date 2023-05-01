Console.WriteLine("## Arrays ##\n");

//Declaração do array
int[] numeros;

//alocação na memória e inicialização
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//simplificação de sintaxe
//A quantidade de nomes é o tamanho do array
string[] nomes = new string[] { "Ana", "Maria", "João", "José" };

//Segue a mesma lógica da anterior.
string[] nomes2 = { "Ana", "Maria", "João", "José" };
//Índice no Array     0  ,    1   ,   2   ,   3

//Para acessar um elemento no array, defino o nome do array e o índice
Console.WriteLine($"Elemento 0: {nomes2[0]}");
Console.WriteLine($"Elemento 1: {nomes2[1]}");
Console.WriteLine($"Elemento 2: {nomes2[2]}");
Console.WriteLine($"Elemento 3: {nomes2[3]}");

//Caso não inicialize o array, ele alocará o espaço na memória com os valores padrão do tipo definido
int[] numeros2;

numeros2 = new int[3];
Console.WriteLine($"\nArray 'números2' na posição 0: {numeros2[0]}");
Console.WriteLine($"Array 'números2' na posição 1: {numeros2[1]}");
Console.WriteLine($"Array 'números2' na posição 2: {numeros2[2]}");

//Para atribuir valores aos indices
numeros2[0] = 1;
numeros2[1] = 2;
numeros2[2] = 3;

Console.WriteLine($"\nArray 'números2' na posição 0: {numeros2[0]}");
Console.WriteLine($"Array 'números2' na posição 1: {numeros2[1]}");
Console.WriteLine($"Array 'números2' na posição 2: {numeros2[2]}");


Console.ReadLine();