using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===============================================");

var employee = new EmployeeInMemory("Tomasz", "Szletter","M", 32);

employee.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("dodano nową ocenę");
}

employee.GradeAdded -= EmployeeGradeAdded;

employee.AddGrade(5);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli koniec, nacisnij 'q/Q') :");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}


Console.WriteLine($"Tomasz Szletter - Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Tomasz Szletter - Average: {statistics.Average:N2}");
Console.WriteLine($"Tomasz Szletter - Min: {statistics.Min}");
Console.WriteLine($"Tomasz Szletter - Max: {statistics.Max}");


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