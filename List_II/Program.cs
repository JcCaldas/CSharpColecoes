Console.WriteLine("## List<T> 2 ##\n");

//Adicionando elemento na list<t>

Console.WriteLine("Lista Original");
var lista = new List<string>()
{
    "Maria", "Ana", "Pedro", "Carlos", "José"
};

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista[i]}");
}

Console.WriteLine("\nAdicionando \"Marta\" ao final da lista");

lista.Add("Marta"); //Adiciona ao final da Lista
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista[i]}");
}

Console.WriteLine("\nAdicionando \"Bia\" no índice 2");

lista.Insert(2, "Bia"); //Adiciona "Bia" no indice 2
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista[i]}");
}

Console.WriteLine("\nAdicionando Arrays na lista");
Console.WriteLine("Lista Original");

var lista2 = new List<string>()
{
    "Maria", "Ana", "Carlos"
};

for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}

string[] array1 = { "Diná", "José", "Marta" };

Console.WriteLine("\nAdiconando Array ao final da lista");
lista2.AddRange(array1); //Adiciona o array ao final da lista
for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}

Console.WriteLine("\nAdicionando Array no índice 1");
lista2.InsertRange(1, array1);
for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}

//Removendo elementos da List<T>
Console.WriteLine("\nRemovendo primeira ocorrência de \"José\"");

lista2.Remove("José"); //Remove a primeira ocorrência do objeto especificado

lista2.InsertRange(1, array1);
for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}

Console.WriteLine("\nRemovendo elemento do índice 3");

lista2.RemoveAt(3);//Remove o elemento do indice informado

for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}
Console.ReadKey();

Console.WriteLine("\nRemovendo 3 elementos a partir do índice 1");

lista2.RemoveRange(1, 3);//Remove a quantidade de elementos informados a partir do índice informado (índice, elementos)

for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}

//Substituindo um elemento

Console.WriteLine("\nSubstituindo um elemento de determina índice [0] e [2]");

lista2[0] = "Zakeu"; //Substitui elemento do índice indicado [0]
lista2[2] = "Jessé"; //Substitui elemento do índice indicado [2]

for (int i = 0; i < lista2.Count; i++)
{
    Console.WriteLine($"[{i}] - {lista2[i]}");
}

//Verificando se a lista contém ou não um elemento

Console.WriteLine("\nVerificando um elemento da lista");

var res1 = lista2.Contains("Jessé"); //True
var res2 = lista2.Contains("Jesse"); //False - A string tem que ser exatamente do jeito que é escrita
var res3 = lista2.Contains("Maria"); //False

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);

//Ordenar a lista (ondem crescente)

Console.WriteLine("\nLista:");
foreach (var item in lista2)
{
    Console.WriteLine($"{item} ");
}

Console.WriteLine("\nLista ordenada:");
lista2.Sort();
foreach (var item in lista2)
{
    Console.WriteLine($"{item} ");
}

//Apagando a lista
Console.WriteLine("\nApagando a lista:");
Console.WriteLine($"Quantidade de elementos na lista: {lista2.Count}");
lista2.Clear();
Console.WriteLine($"Quantidade de elementos na lista após apagar: {lista2.Count}");


Console.ReadKey();