namespace Task5;

class Datetimeandtimespan
{
    static void Main(string[] args)
    {
        DateTime birthdate = new DateTime(1985, 03, 01);
        DateTime currentDate = DateTime.Today;
        
        TimeSpan timeAlive =  currentDate - birthdate;
        int age = currentDate.Year - birthdate.Year;

        if (timeAlive < birthdate.AddYears(age) - birthdate)
            age--;
        
        Console.WriteLine($"Birthdate is : {birthdate:D}");
        Console.WriteLine($"Current date and time: {currentDate}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Birthdate plus 10 days: {birthdate.AddDays(10):d}");
        
    }
}