using ChallengeApp;

Console.WriteLine("Witaj w programie XYZ do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();
Console.WriteLine("Dodaj ocenę pracownika");

var employee = new Employee("Tomasz", "Szletter");
while (true)
{
    Console.WriteLine("Dodaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q") 
    {  
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

//Console.WriteLine(input);




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