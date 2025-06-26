using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Producao[] producoes = new Producao[n];
        for (int i = 0; i < n; i++)
        {
            string[] producao = Console.ReadLine().Split(';');
            producoes[i] = new Producao(producao);
        }
        OrdenarPorData(producoes);
        OrdemAlfabetica(producoes);
        for (int i = 0; i < producoes.Length; i++)
            Console.WriteLine(producoes[i].ToStringFormatado());
    }

    static void OrdenarPorData(Producao[] producoes)
    {
        //iremos utilizar o algoritmo de inserção
        for (int i = 1; i < producoes.Length; i++)
        {
            Producao temp = producoes[i];
            int j = i - 1;
            while ((j >= 0) && (producoes[j].Ano() > temp.Ano()))
            {
                producoes[j + 1] = producoes[j];
                j--;
            }
            producoes[j + 1] = temp;
        }
    }

    static void OrdemAlfabetica(Producao[] producoes)
    {
        for (int i = 0; i < producoes.Length - 1; i++)
        {
            if ((producoes[i].Ano() == producoes[i + 1].Ano()) && (string.Compare(producoes[i].Titulo(), producoes[i + 1].Titulo()) > 0))
            {
                Producao temp = producoes[i];
                producoes[i] = producoes[i + 1];
                producoes[i + 1] = temp;
            }
        }
    }
}
class Producao
{
    //atributos aqui
    private string show_id;
    private string type;
    private string title;
    private string director;
    private string cast;
    private string country;
    private string date_added;
    private int release_year;
    private string rating;
    private string duration;
    private string listed_in;
    private string description;
    //função construtora
    public Producao(string[] producao)
    {
        show_id = producao[0];
        type = producao[1];
        title = producao[2];
        director = producao[3];
        cast = producao[4];
        country = producao[5];
        date_added = producao[6];
        release_year = int.Parse(producao[7]);
        rating = producao[8];
        duration = producao[9];
        listed_in = producao[10];
        description = producao[11];
    }

    public int Ano() => release_year;

    public string Titulo() => title;

    public string ToStringFormatado()
    {
        return $"{show_id};{type};{title};{director};{cast};{country};{date_added};{release_year};{rating};{duration};{listed_in};{description}";
    }
}