namespace Indexadores;

internal class Time
{
    //definir os limites do array
    /*Como será um array de nome de times, será do tipo
     string, mas poderia ser de qualquer outro tipo.*/

    string[] valor = new string[10];

    /*criando indexador:
     modificadorDeAcesso tipo palavraReservadaThis [definir os parâmetros]*/
    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < valor.Length)
            {
                //retorna o valor
                return valor[i];
            }
            return "Erro";
        }

        set
        {
            if ( i >=0 && i < valor.Length)
            {
                //atribui o valor
                valor[i] = value;//value representa o valor atribuido
            }
        }
    }
}
