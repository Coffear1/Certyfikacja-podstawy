using Certyfikacja_podstawy;

Console.WriteLine("Witamy w programie do liczenia zdobytych goli w sezonie piłkarskim");
Console.WriteLine("=========================================");
Console.WriteLine();

var footballer = new FootballerInMemory(string.Empty, string.Empty, string.Empty);
footballer.ScoreAdded += FootballerScoreAdded;


void FootballerScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("Świetny wynik tego zawodnika");
}

var name = footballer.Name;
var surname = footballer.Surname;
var nationality = footballer.Nationality;

int counter = 0;

Console.WriteLine("Podaj imię, nazwisko oraz narodowość piłkarza");
Console.WriteLine();
name = Console.ReadLine();
surname = Console.ReadLine();
nationality = Console.ReadLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Podaj kolejną liczbę zdobytych goli");
    var input = Console.ReadLine();
    
    try
    {
        footballer.AddScore(input);
       
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    counter++;
    if (counter == 5)
    {
        break;
    }
}

Console.WriteLine();
Console.WriteLine("==========================================================");
var statistics = footballer.GetStatistics();
Console.WriteLine("====== STATYSTYKI ======");
Console.WriteLine();
Console.WriteLine($"Średnio gole zdobyte na mecz: {statistics.Average:N2}");
Console.WriteLine($"Minimalna liczba goli w meczu : {statistics.Min}");
Console.WriteLine($"Maksymalna liczba goli w meczu: {statistics.Max}");
Console.WriteLine($"Wszystkie gole w sezonie: {statistics.Sum}");
Console.WriteLine($"Ocena podczas sezonu: {statistics.MatchRating}");


