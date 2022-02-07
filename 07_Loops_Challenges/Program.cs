int number = 525;

//for (int i = 500; i <= number; i++)
//{
//    Console.WriteLine(i);
//}


int zeroHundred = 0;
while (zeroHundred <= 100)
{
    Console.WriteLine(zeroHundred);
    zeroHundred = zeroHundred + 5;
}


for (int f = 1; f <= 100; f++)
{
    if (f % 3 == 0 && f % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (f % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (f % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
        Console.WriteLine(f);
}