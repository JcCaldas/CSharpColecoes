Console.WriteLine("Exercício 10");

Alunos alunos = new Alunos();
alunos[10] = "João"; //Essa atribuição dará um erro proposital.
alunos[9] = "Rebeca";
alunos[8] = "Karla";
alunos[7] = "Carlos";
alunos[6] = "Jessé";
alunos[5] = "Liliane";
alunos[4] = "José";
alunos[3] = "Alice";
alunos[2] = "Renata";
alunos[1] = "Augusto";
alunos[0] = "Roberto";

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(alunos[i]);
}