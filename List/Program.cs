Console.WriteLine("## List<T> ##\n");

/*Declarar uma coleção do tipo List<T>
 T -> Tipo de elementos da lista

 Tenho acesso ao Count e Capacity, assim como Array List*/

List<string> lista; //declaração
lista = new List<string>(); //inicialização

List<int> lista1 = new List<int>();//declara e inicia


var lista2 = new List<float>();//declara e inicia
List<double> lista3 = new();//declara e inicia - nova sintaxe e mais usada

//Adicionando itens na lista
List<string> nomes = new();
nomes.Add("Paulo");//adiciona ao final da lista
nomes.Add("Maria");//adiciona ao final da lista

//pode ser adicionado da seguinte maneira.
var lista4 = new List<string>()
{
    "Paulo", "João", "Bia", "Pedro"
};



Console.ReadKey();