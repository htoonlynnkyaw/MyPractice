for(int i = 1; i <=100; i++)
{
    string suffixtext = "";

    if (i%3 == 0 && i%5 == 0)
    {
        suffixtext = "FizzBuzz";
    }
    else if (i%3 == 0)
    {
        suffixtext = "Fizz";
    }
    else if (i%5 == 0)
    {
        suffixtext = "Buzz";
    }

    Console.WriteLine($"{i} {suffixtext}");    
}