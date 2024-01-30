//jan 24 class (2)

using System.ComponentModel.Design;

//CONTROL STATEMENTS

bool isEligible = true;
if(isEligible)
{
    Console.WriteLine("You are eligible.");
}
//if condition is true, it runs code within the brackets

int age = 20;

if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if (age < 18)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("What is the game score?");
//string userInput = Console.ReadLine();
//int gameScore = int.Parse(userInput);

int gameScore = int.Parse(Console.ReadLine());
//can do it in one line, but with this method we can't check what the user method was and makes it harder to debug 

if(gameScore >= 90)
{
    Console.WriteLine("Great job");

}
else if (gameScore >= 70) // dont need && < 90 because the code wont get here if its not less than 90
{
    Console.WriteLine("Good job");
}
else
{
    Console.WriteLine("You can do better");
}


Console.WriteLine("New Message");
//code will still write the part after the brackets 


//SWITCH STATEMENTS
int dayNumber = 3;

if(dayNumber == 1)
{
    Console.WriteLine("Monday");
}
else if (dayNumber == 2)
{
    Console.WriteLine("Tuesday");
}
// non clean way to do this -- for example

switch(dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default: // best practice is to have a default just in case 
        Console.WriteLine("That is not a day");
        break;
}

//on assessment or something 

Console.WriteLine("Select an option:\n 1.Play \n 2.Settings \n 3.Exit ");
string userInput = Console.ReadLine();
int option = int.Parse(userInput);

switch(option)
{
    case 1:
        Console.WriteLine("Starting game...");
        break;
    case 2:
        Console.WriteLine("Opening settings...");
        break;
    case 3:
        Console.WriteLine("Exiting...");
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}


Console.WriteLine("How are you feeling");
userInput = Console.ReadLine();

switch(userInput.ToLower().Trim())
{
    case "bad":
    case "sad":
    case "unhappy":
        Console.WriteLine("I'm sorry you aren't feeling great");
        break;
    case "good":
        Console.WriteLine("I'm happy you feel that way");
        break;
    default:
        Console.WriteLine("I don't know that feeling");
        break;
}

Console.ReadKey();

// Syntax: condition you're checking , valueIfTrue : valueIfFalse

string mirrorEmotion = userInput.ToLower() == "bad" ? "Anger" : "Joy";
//single line that solves for if or else 

Console.ReadKey();
