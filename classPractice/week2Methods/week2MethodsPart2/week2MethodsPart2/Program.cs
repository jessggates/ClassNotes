
GreetUser();
Console.ReadKey();


static void GreetUser()
{
    Console.WriteLine($"Hello, welcome to my program!");
    Console.Write("What is your name?: ");
    string userName = Console.ReadLine();
    Console.Write("How old are you?: ");
    int userAge = GetValidInteger(Console.ReadLine());
    PrintNameAndAge(userName, userAge);
    Random randomGenerator = new Random();
    int computerAge = randomGenerator.Next(userAge + 1, 200);
    int ageDifference = CalculateDifference(computerAge, userAge);
}


static void PrintNameAndAge(string name, int age) 
{
    Console.WriteLine($"Your name is {name}. You are {age} years old");
}

static int CalculateDifference(int firstNumber, int secondNumber)
{
    int returnValue = firstNumber - secondNumber;
    return returnValue;
}


static int GetValidInteger(string stringToCheck)
{
    int returnValue = 0;

    do
    {

        try
        {
            returnValue = int.Parse(stringToCheck); // this checks that the entry can go into the integer when parsing
        }
        catch (FormatException)
        {
            returnValue = -1;
        }

        if(returnValue == -1) // the if checks that this is > 0
        {
            Console.WriteLine("That is not an integer value. Please enter another value.");
            stringToCheck = Console.ReadLine();
        }

    } while (returnValue < -1);

    return returnValue;
}

