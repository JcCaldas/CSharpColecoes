public class Alunos
{
    string[] Nomes = new string[10]; 

    public string this [int i]
    {
        get
        {
            if (i >= 0 && i < Nomes.Length)
            {
                return Nomes[i];
            }
            else
            {
                return "Erro!";
            }
        }

        set
        {
            if (i >=0 && i < Nomes.Length)
            {
                Nomes[i] = value;
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }
    }
}