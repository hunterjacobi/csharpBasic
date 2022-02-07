string instructorName = "Jacob";
string[] instructors = new string[] { "Adam", "Kate", instructorName };
// List<string>

// foreach(declaredIterator in enumerableCollection){body}

foreach (string name in instructors)
{
    Console.WriteLine($"Hello {name}");
}

foreach (char letter in instructorName)
{
    if (letter == 'c')
    {
        Console.WriteLine('k');
    }
    else
        Console.WriteLine(letter);
}

//Exercise
int[] numbers = new int[] { -4, -1, 0, 3, 7, 11 };

foreach (int num in numbers)
{
    if (num > 0)
    {
        Console.WriteLine($"{num} is positive.");
    }
    else if (num < 0)
    {
        Console.WriteLine($"{num} is negative.");
    }
    else
        Console.WriteLine($"{num} is neither positive or negative.");

}