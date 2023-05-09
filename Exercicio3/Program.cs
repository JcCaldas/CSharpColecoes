using Exercicio3;

Console.WriteLine("## Exercício 3 ##\n");

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

Console.WriteLine("\nAdicionando Bia e Fábio:");

alunos.Add(new Aluno() { Nome = "Bia", Nota = 7.75});
alunos.Add(new Aluno() { Nome = "Fábio", Nota = 8.95});

ExibirAlunos(alunos);

Console.WriteLine("\nRemovendo Amanda:");

for (int i = 0; i < alunos.Count; i++)
{
    if (alunos[i].Nome == "Amanda")
        alunos.RemoveAt(i);
}

ExibirAlunos(alunos);

Console.WriteLine("\nLista Ordenada pelo nome.");

//Método sort() não funciona pois a Lista criada é um objeto complexo.
var listaOrdenada = alunos.OrderBy(a => a.Nome).ToList(); //Cria uma variavel que recebe a lista ordenada, no critério da expressão lâmbida, transformada em lista

ExibirAlunos(listaOrdenada);

Console.WriteLine("\nAlunos com nota maior que 8:");

Console.WriteLine("\nNome\tNota\n");

var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);//Encontra o que está na expressão lâmbida

ExibirAlunos(alunosNotaOito);

//for (int i = 0;i < alunos.Count; i++)
//{
//    if (alunos[i].Nota >= 8)
//        Console.WriteLine($"{alunos[i].Nome}\t{alunos[i].Nota}");
//}



Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    double media, soma = 0;
    int contador = 0;
    
    Console.WriteLine("\nRelação de alunos");
    Console.WriteLine("\nNome\tNota\n");

    foreach (var aluno in alunos)
    {
   
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        soma += aluno.Nota;
        contador++;
    }

    media = soma / contador;

    Console.WriteLine($"\nMédia:\t{Math.Round(media,2)}");//Class Math.Round (variavel, quantidad de casas decimais)
    Console.WriteLine($"Total de alunos:\t{contador}");
}