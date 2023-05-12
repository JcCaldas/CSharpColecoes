using System.Collections;

Console.WriteLine("Exercício 9\n");

List<object> lista = new List<object>()
{
    1,
    "Maria",
    3.5m,
    new Teste(),
    null

};

ProcessaObjetos(lista);


Console.ReadKey();

static void ProcessaObjetos(List<object> objetos)
{
    foreach (object objeto in objetos)
    {
        if (objeto != null)
            Console.WriteLine($"Objeto: {objeto}\tTipo: {objeto.GetType()}");

        else
            Console.WriteLine("Objeto Nulo");
    }

}

public class Teste
{

}

