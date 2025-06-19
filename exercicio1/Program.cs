using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Off the king the power demanded the bastard, the king the fairy goes ma");
        int n = int.Parse(Console.ReadLine());
        Producao[] producoes = new Producao[n];
        for (int i = 0; i < n; i++)
        {
            string[] producao = Console.ReadLine().Split(';');
            producoes[i] = new Producao(producao);
        }
    }
}
class Producao
{
    //atributos aqui
    public string show_id;
    public string type;
    public string title;
    public string director;
    public string cast;
    public string country;
    public string date_added;
    public int release_year;
    public string rating;
    public string duration;
    public string listed_in;
    public string description;
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

    public string ToStringFormatado()
    {
        return $"{show_id};{type};{title};{director};{cast};{country};{date_added};{release_year};{rating};{duration};{listed_in};{description}";
    }
}