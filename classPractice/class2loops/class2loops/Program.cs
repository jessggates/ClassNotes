

for(int i = 0; i <=10; i++)
{
    Console.WriteLine($"Loop iteration {i}");
// this is where i++ happens
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"Loop iteration {i}");
}

for (int i = 0; i > 0 && i <= 20; i+=2)
{
    Console.WriteLine($"Loop iteration {i}");
}


for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
{
    Console.WriteLine($"Table for {firstNumber}");
    for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
    {
        Console.Write($"{firstNumber} * {secondNumber}=");
        Console.WriteLine($"{firstNumber * secondNumber}");
    }
}

Console.ReadKey();


