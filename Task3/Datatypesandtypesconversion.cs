namespace Task3;

class Datatypesandtypesconversion
{
    static void Main(string[] args)
    {
        byte byteVal = 10;
        short shortVal = 200;
        int intVal = 42;
        long longVal = 100L;
        float  floatVal = 1.5f;
        double doubleVal = 2.5;
        decimal decimalVal = 3.5m;
        char charVal = 'W';
        bool boolVal = true;
        
        string convertedStr = intVal.ToString();
        double convertedDouble = double.Parse("3.14");
        
        Console.WriteLine($"Byte Value is {byteVal}");
        Console.WriteLine($"Short Value is {shortVal}");
        Console.WriteLine($"Int Value is {intVal}");
        Console.WriteLine($"Long Value is {longVal}");
        Console.WriteLine($"Float Value is {floatVal}");
        Console.WriteLine($"Double Value is {doubleVal}");
        Console.WriteLine($"Decimal Value is {decimalVal}");
        Console.WriteLine($"Char Value is {charVal}");
        Console.WriteLine($"Boolean Value is {boolVal}");
        Console.WriteLine($"String Value is {convertedStr}");
        Console.WriteLine($"Converted Double value is {convertedDouble}");
    }
}