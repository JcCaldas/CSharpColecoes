using System.Collections;

Console.WriteLine("## Array List ##\n");

//Formas de declarar Arraylist
/*ArrayLists podem receber diferentes tipos de elementos
 no mesmo arraylist*/
//count = 0 (quantidade de elementos) e capacity = 0 (capacidade. Incrementada de 4 em 4)
//1
ArrayList lista; //valor da lista: null
lista = new ArrayList();//count = 0, capacity = 0

//2
ArrayList lista1 = new ArrayList();//count = 0, capacity = 0

//3
var lista2 = new ArrayList();//count = 0, capacity = 0

//4 - mais recente
ArrayList lista3 = new();//count = 0, capacity = 0

//Definindo Capacity
//propriedade count = 0 (quantidade de elementos) e capacity = 5 (capacidade. Incrementada de 4 em 4)
//1
ArrayList lista4;
lista = new ArrayList(5);//count = 0, capacity = 5

//2
ArrayList lista5 = new ArrayList(5);//count = 0, capacity = 5

//3
var lista6 = new ArrayList(5);//count = 0, capacity = 5

//4 - mais recente
ArrayList lista7 = new(5);//count = 0, capacity = 5

//Adicionando elementos
//1
ArrayList lista8 = new();//count = 0, capacity = 0

lista8.Add("Paulo");
lista8.Add(4.5);
lista8.Add(5);
lista8.Add(true);
lista8.Add(" ");
lista8.Add(null);
//ao final: count = 6, capacity = 8

//2 - inicializando objetos
var lista9 = new ArrayList() { "Paulo", 4.5, 5, true, " ", null };//count = 6, capacity = 8

Console.ReadKey();