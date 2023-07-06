using ChallengeApp;

Console.WriteLine("Witam w programie XYZY do oceny roboli");
Console.WriteLine("======================================");
Console.WriteLine();

var employee = new Employee();

while (true) 
{
    Console.WriteLine("Wpisz kolejną ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    { 
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Minimal: { statistics.Min}");
Console.WriteLine($"Maximum: { statistics.Max}");



//walidacja - sprawdzenie poprawnosci danych.
//co to jest ref:
// przygotowanie metody
// void (SetSth (ref Statistics statistics)
//{
//-statistics = new Statistics ();
//}
// out ref to samo. jedyna różnica musimy nadpisac w metodze statistics.
// ref oznacza przekazany parametr ma juz przypisana wartosc
// out nie posiada wartosci i trzeba ja dopisać.
// model danych: klasa z pewnymi proporcjami bez logiki. kilka danych , statystyki itd. 
// interpolacja dla liczb zmienno przecinkowych.
//przekazywane parametry w metodach  = przez wartosc / referencje.