namespace Task6;

class GenericCollectionsListsandDictionaries
{
    static void Main(string[] args)
    {
        List<string> fruits = new() { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits:");
        foreach (string fruit in fruits)
            Console.WriteLine(fruit);

        Dictionary<int, string> fruitIDs = new()
        {
            {1, "Apple"},
            {2, "Banana"},
            {3, "Mango"}
        };
        fruitIDs.Add(4, "Orange");

        Console.WriteLine("Fruit IDs:");
        foreach (var entry in fruitIDs)
            Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
}

