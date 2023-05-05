using System.Collections;

Console.WriteLine("## Array List II ##\n");

var lista = new ArrayList()
{
    "Maria", //0
    5,       //1
    true,    //2
    " ",     //3
    null     //4
};

lista.Add(3.5); //Adiciona ao final da lista.

lista.Insert(2, "Paulo"); //Adiciona na posição informada (POSIÇÃO, ELEMENTO)


//Adicionando coleção de elementos:

var lista2 = new ArrayList()
{
    "Maria", //0
    5,       //1
    true     //2
};

int[] array1 = { 1, 2, 3, 4, 5 };

lista2.AddRange(array1); //Adiciona a coleção de elementos no final
lista2.InsertRange(2, array1); //Adiciona a coleção de elementos a partir da posição informada (POSIÇÃO, COLEÇÃO DE ELEMENTOS)

//Removendo elementos
var lista3 = new ArrayList()
{
    "Ana",
    5,
    " ",
    true,
    null,
    1.1,
    "Zé",
    3,
    9,
    5,
    0

};

for (int i = 0; i < lista3.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista3[i]}");
}

lista3.Remove(5); //remove a primeira ocorrência do elemento indicado

Console.WriteLine();
for (int i = 0; i < lista3.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista3[i]}");
}

lista3.RemoveAt(4); //remove o elemento do índice 4

Console.WriteLine();
for (int i = 0; i < lista3.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista3[i]}");
}

lista3.RemoveRange(0, 2); //remove, a partir da posição, a quantidade de elementl (POSIÇÃO, QUANTIDADE)


Console.WriteLine();
for (int i = 0; i < lista3.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista3[i]}");
}


//Verificando se um elemento está na coleção

var lista4 = new ArrayList()
{
    "Maria",
    5,
    true,
    4.5,
    null,
    DateTime.Now
};

Console.WriteLine();
for (int i = 0; i < lista4.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista4[i]}");
}

var res1 = lista4.Contains(5); //True
Console.WriteLine($"Contém int 5 - {res1}");
var res2 = lista4.Contains(null); //True 
Console.WriteLine($"Contém null - {res2}");

bool res3 = lista4.Contains(45); //False
Console.WriteLine($"Contém int 45 - {res3}");
bool res4 = lista4.Contains("Mari"); //False
Console.WriteLine($"Contém Mari - {res4}");


Console.WriteLine($"Contém Maria - {lista4.Contains("Maria")}");//True

//Organizando ArrayList
/*Todos os elementos devem ser do mesmo tipo
 para que a organização de elementos funcione.*/

var lista5 = new ArrayList()
{
    "Maria",
    "Ana",
    "Zilda",
    "Carlos",
    "Diná"
};

Console.WriteLine("\nArrayList Original");
for (int i = 0; i < lista5.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista5[i]}");
}

lista5.Sort();

Console.WriteLine("\nArrayList ordenada");
for (int i = 0; i < lista5.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista5[i]}");
}

//Apagando ArrayList

Console.WriteLine($"\nNúmero de elemento no ArrayList: {lista5.Count}");

lista5.Clear();

Console.WriteLine($"\nNúmero de elemento no ArrayList após o clear: {lista5.Count}");



Console.ReadKey();