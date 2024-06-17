using Certyfikacja_podstawy;


Console.WriteLine("Witamy w programie do liczenia zdobytych goli w sezonie piłkarskim");
Console.WriteLine("=========================================");
Console.WriteLine();

void FootballerScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("Świetny wynik tego zawodnika");
}

int counter = 0;

Console.WriteLine("Podaj imię i wciśnij Enter:");
var name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Podaj nazwisko i wciśnij Enter:");
var surname = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Podaj narodowość i wciśnij Enter:");
var nationality = Console.ReadLine();

var footballer = new FootballerInMemory(name, surname, nationality);

footballer.ScoreAdded += FootballerScoreAdded;

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
Console.WriteLine($"Zawodnik: {footballer.Name} {footballer.Surname}");
Console.WriteLine($"Kraj pochodzenia: {footballer.Nationality}");
Console.WriteLine();
Console.WriteLine($"Średnio gole zdobyte na mecz: {statistics.Average:N2}");
Console.WriteLine($"Minimalna liczba goli w meczu : {statistics.Min}");
Console.WriteLine($"Maksymalna liczba goli w meczu: {statistics.Max}");
Console.WriteLine($"Wszystkie gole w sezonie: {statistics.Sum}");
Console.WriteLine($"Ocena podczas sezonu: {statistics.MatchRating}");


