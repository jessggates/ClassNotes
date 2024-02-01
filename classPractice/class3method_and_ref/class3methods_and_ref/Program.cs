// Week 2 day 2 (Wednesday)



Console.WriteLine("How many of The Things do you want?");
bool isValid = int.TryParse(Console.ReadLine(), out int amount);
if (isValid == false)
{
    Console.WriteLine("I don't like your attitude! GOODBYE");
    Environment.Exit(0);
}

DoubleAmountIfSpecial(ref amount);




static void DoubleAmountIfSpecial(ref int amount) //reference is the memory address of the variable 
{
    if (amount == 4)
    {
        Console.WriteLine("You get double for the same price!");
        amount = amount * 2;
    }
}





Console.ReadKey();



Console.WriteLine("How old are you?");
string userInput = Console.ReadLine();
//bool isValid = IsValidAge(userInput, out int userAge);

bool isValue = int.TryParse(userInput, out int userAge); //try parse catches the exception dont have to try catch every time



if (isValid == true)
{
    age = int.Parse(userInput);
}
else
{
    //retry logic to give us name
}




static bool IsValidAge(string stringToCheck, out int age)
{
    age = -1;
    try
    {
        age ...///
    }
}


// Best Practices for tackling something 
// noun is a variable 
// verb is a method 
// input vs output 
// ifs thens are condeitions
// do whiles for looping and doing things again

