

//Random Class 

Random randomGenerator = new Random();

//next method is used to actually generate the pseudo-random number (not true true random if it's important)

int randomInteger = randomGenerator.Next();
//generates a non-negative integer 

int newRandomNumber = randomGenerator.Next(1,11);
//min value is inclusive, max value is exclusive (1-10 needs to be 1,11)

int diceRoll = randomGenerator.Next(1, 7);

// Methods 

int.Parse(Console.ReadLine()); //is a method
Console.WriteLine(); //is a method - takes no input (parameters), gives no output (return value)
Console.ReadLine(); // is a method - takes no input (has no parameters), but gives you the text that was entered (returning a string)
Console.WriteLine("something"); // has a parameter , takes input, but gives no output .. just does its job
int age = int.Parse("53"); // has parameter (expecting input), has a return type 

// void methods are defined with keyword void before the method name 

string name = "HAL";

PrintName(name);

GreetUser();
PrintName("Jessica"); //whats in the quotes is the argument 
PrintNameAndAge("Griffin", 53);
PrintNameAndTitle("developer", "jered"); // handling out of order will be handled when we learn classes 


int sum = CalculateSum(2, 5);

string userAge = Console.ReadLine();
int validInteger = CheckValidInteger(userAge);
if (validInteger == -999)
{
    Console.WriteLine("This is not a valid age");
}

string message = CreateGreeting(name);

















static void GreetUser() //dont need the static in there when we create since visual studio code 
{
    Console.WriteLine("Hello, welcome to my program!");
}

//if you copy and paste code more than 1, create a method ... better to have more smaller methods than 1 big method (shouldnt have a lot of code)


static void PrintName(string name)//this is the parameter
{
    Console.WriteLine($"Your name is {name}");
}
//had to enter a string into the PrintName method parameters since it's asking for a parameter


static void PrintNameAndAge(string name, int age) // dont have more than 4 parameters coming into your method
{
    Console.WriteLine($"You name is {name}. You are {age} years old");
}
// can have as many parameters as you want but have to pass them in the right order 

static void PrintNameAndTitle(string name, string title)
{
    Console.WriteLine($"Your name is {name}, your title is {title}");
}

static int CalculateSum(int firstNumber, int secondNumber)
{
    int returnValue = firstNumber + secondNumber;
    return returnValue;
}

static int CheckValidInteger(string stringToCheck)
{
    int returnValue = 0;
    try 
    {
        returnValue = int.Parse(stringToCheck);
    }
    catch (FormatException)
    {
        returnValue = -999;
    }
    return returnValue;
}


static string CreateGreeting(string name)
{
    return $"Hello, {name}";
}