

string userInput = "";

bool continueLooping = true; // this is an infinite loop 
while (continueLooping == true)
{
    Console.WriteLine("Do you want to play again (yes/no)?");
    userInput = Console.ReadLine();

    switch(userInput.ToLower().Trim())
    {
        case "yes":
        case "y":
            Console.WriteLine("Great, I love playing games with you.");
            break;
        default:
            Console.WriteLine("You didn't say yes, so I'll see you later");
            break;
    }
}

bool playAgain;

do
{
    Console.WriteLine("This is the spot we are playing our game. Isn't it fun");
    Console.WriteLine("Now our game is done");
    Console.WriteLine("Do you want to play again? (y/n)");
    playAgain = Console.ReadLine() == "y"; ? true : false;
}
 while (playAgain);

}
Console.WriteLine("Goodbye!");



while (userInput.ToLower().Trim() != "exit")
{
    Console.Write("Enter a command (type 'exit' to stop): ");
    userInput = Console.ReadLine();
    Console.WriteLine(userInput);
}



bool isDataValid = false;
int hoursWorked = 0;
double hourlyWage = 0;
do
{
    Console.WriteLine("What is your hourly wage?");
    userInput = Console.ReadLine();
    try
    {
        hourlyWage = double.Parse(userInput);
    }
    catch (FormatException)
    {
        isDataValid = false;
    }
    if (isDataValid == true)
    {
        if (hourlyWage < 1)
        {
            isDataValid = false;
        }
    }
} while (isDataValid == false);

// get hours worked 


string userInput = true;

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("Done");
Console.ReadKey();

//jump statement let's do break out of a loop 


while(true)
{
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine().ToLower().Trim();
    if(userName == "scott")
    {
        break;
    }
}

Console.Write("Give me a number: ");
int userNumber = int.Parse(Console.ReadLine());

for (int i = 0; i <= userNumber; i++)
{
    if (i % 2 == 0)
    {
        continue;
            }
    Console.WriteLine(i);
}

// will only print odd numbers 