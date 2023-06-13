using ChallengeApp;

var employee = new Employee("Tomasz", "Szletter");
employee.AddGrade("4000");
employee.AddGrade(1f);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

//walidacja - sprawdzenie poprawnosci danych.


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



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