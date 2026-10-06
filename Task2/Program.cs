namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        // Circle.PI = 3.14159;
        double radius = 5;
        
        Console.WriteLine($"Area = {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter = {Circle.CalculatePerimeter(radius)}");
    }
}


