Console.WriteLine("## Arrays Bidimensionais ##\n");

//declara um array, do tipo int, bidemensional.
int[,] a; //valor de "a" = null

//alocando memória para o array com 2 linha e 2 colunas
a = new int[2, 2]; //valores atribuidos as linhas e colunas = 0

//inicializando o array
a[0, 0] = 0; //linha 0 coluna 0
a[0, 1] = 1; //linha 0 coluna 1
a[1, 0] = 2; //linha 1 coluna 0
a[1, 1] = 3; //linha 1 coluna 1

Console.WriteLine("Array A");
Console.WriteLine("Linha | Coluna");
Console.WriteLine($"{a[0, 0]} | {a[0, 1]}");
Console.WriteLine($"{a[1, 0]} | {a[1, 1]}");

//tudo em 1 etapa
//int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };
int[,] b = { { 20, 30 }, { 40, 50 } };

Console.WriteLine("\nArray B");
Console.WriteLine("Linha | Coluna");
Console.WriteLine($"{b[0, 0]} | {b[0, 1]}");
Console.WriteLine($"{b[1, 0]} | {b[1, 1]}");

//Laços em Arrays Bidimensionais

Console.WriteLine("\nLaços em arrays bidimensionais\n");

//n [3 linhas, 3 colunas] => n[i, j]
int[,] n = {
            { 11, 22, 33 }, //n[0,0] n[0,1] n[0,2]
            { 44, 55, 66 }, //n[1,0] n[1,1] n[1,2]
            { 77, 88, 99 }  //n[2,0] n[2,1] n[2,2]
};

//Laço for dá mais controle na hora de varrer os elementos.
Console.WriteLine("Laço for:\n");
//GetLength() => 0 para 1ª dimensão, 1 para 2ª dimensão e assim por diante.
for (int i = 0; i < n.GetLength(0); i++) //Primeiro for é para a linha
{
    for (int j = 0; j < n.GetLength(1); j++) //Segundo for é para a coluna
    {
        Console.Write($"{n[i,j]} ");
    }
    Console.WriteLine();
}

//No geral ultilizar o foreach para arrays unidimensionais
Console.WriteLine("\nLaço foreach:\n");
foreach (int x in n)
{
    Console.Write($"{x} ");//Ele varre por linha, da esqueda para a direita.
}

Console.ReadKey();