namespace Task1;

class StringandInt
{
    static void Main(string[] args)
    {
        //Declare a variable named userName to store your name and initialize it
        string userName = "Peter";
        //Declare a variable named luckyNumber to store an integer and initialize it to your favorite single-digit number.
        int luckyNumber = 5;
        //Use string interpolation to print a single line of output to the console that says: "Hello, [userName]! Your lucky number is [luckyNumber].”
        Console.WriteLine($"Hello, {userName}!, Your lucky number is {luckyNumber}");
        Console.WriteLine($"Hello, World! We have {userName} with us today and the lucky number of {userName} is {luckyNumber}, Thank You.");
    }
}
