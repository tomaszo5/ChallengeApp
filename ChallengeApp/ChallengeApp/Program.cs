using ChallengeApp;

Console.WriteLine("Witaj w programie XYZ do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();


var employee = new EmployeeInFile("Tomasz", "Szletter");
employee.AddGrade(0.5f);
//while (true)
//{
//    Console.WriteLine("Dodaj kolejną ocenę pracownika");
//    var input = Console.ReadLine();
//    if (input == "q") 
//    {  
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);   
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine($"Exeption catched:{e.Message}");
//    }
//}
//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");





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