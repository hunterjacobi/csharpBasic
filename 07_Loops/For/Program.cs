// Create initial target
int number = 100;

// for (initializer; condition; iterator) (body)

//1     //2       //3        //4
for (int i = 0; i < number; i++)
{
    //5
    Console.WriteLine(i);
}

//1 - for keyword
//2 - Declaration and initillization of iterator
//3 Boolean expression for the loop
//4 - Increment the iterator at the end of the loop
//5 - Body, runs per iteration if the condition is true

int numberTwo = 200;
for (int i = 1; i <= numberTwo; i++)
{
    numberTwo = numberTwo - i;
    Console.WriteLine(numberTwo);
    Console.WriteLine($"i is {i}");
}


// Exercise
Console.WriteLine("Please input a number greater than 0.");
string userNumber = Console.ReadLine();

int userinput = int.Parse(userNumber);

for (int i = 0; i <= userinput; i++)
{
    Console.WriteLine(i);
}