namespace Task4;

class ArrayandArraymethods
{
    static void Main(string[] args)
    {
        int[] numbers = { 7, 3, 9, 1, 5 };
        
        //Ascending 
        Array.Sort(numbers); 
        //Descending
        Array.Reverse(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index {i} is {numbers[i]}");
        }
        int position = Array.IndexOf(numbers, 9);
        Console.WriteLine($"Index of 9 : {position}");
    }
}
