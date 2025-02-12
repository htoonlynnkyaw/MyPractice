int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;
    if (number == 42)
    {
        bool found = false;
    }        
}

if (found)
{
    Console.WriteLine("Set contains 42");
}
    
Console.WriteLine($"Total: {total}");