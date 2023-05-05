Console.WriteLine("## Modificador Params ##\n");

Console.WriteLine("Soma de números inteiros\n");
/*Criação de métodos que recebe um array como parâmetro
 e soma os números do array*/

//método "convencional"
int[] valores = {1, 2, 3, 4, 5};

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);



//método com params
/*Inserindo a palavra reservada "params" no método
 pode-se informar somente os dados, do mesmo tipo,
diretamente como parâmetros no método, ao invés do
array*/

/*Regras:
- Nenhum parâmetro é permitido após a palavra-chave params em uma declaração de método
- Apenas uma palavra-chave params é permitida em uma declaração de método
- Deve ser o último argumento na lista de parâmetros do método
- Se o tipo declarado do parâmetro params não for um array unidimensional, vai ocorrer o erro do compilador CS0225*/
var resultado2 = Calcular2.Soma(1, 2, 3, 4, 5);
Console.WriteLine(resultado2);


Console.ReadKey();

public class Calcular2
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}

public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}