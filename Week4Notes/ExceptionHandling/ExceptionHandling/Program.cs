
try
{
    string nonNumeric = "abc";
    int result = int.Parse(nonNumeric);

    int[] numbers = new int[] { 1, 2, 3 }; // once it has an exception, it doesn't run the rest of the code
    int number = numbers[3];
}
catch (Exception ex)
{
    Console.WriteLine($"An exception occurred: {ex.Message}");
}

Console.ReadKey();

//call stack will tell you where your errors are 

//if there's 2 pieces of code that may cause errors, split them up 

try
{
    string nonNumber = "abc";
    int result = int.Parse(nonNumber);
}
catch (Exception ex)
{
    Console.WriteLine($"An exception occurred: {ex.Message}");
}


try
{
    int[] numbers = new int[] { 1, 2, 3 };
    int number = numbers[3];
}
catch (Exception ex)
{
    Console.WriteLine($"An exception occurred: {ex.Message}");
}


bool continueLoop = true;
Console.WriteLine("I've got pizza to divide among you. How many students are there?");

while (continueLoop)
{
    try
    {

        string input = Console.ReadLine();
        int numberOfStudents = int.Parse(input);
        int numberOfSlices = 48;
        int piecesPerStudent = numberOfSlices / numberOfStudents;
        //this would be the spot for extra validation logic w/ business rules
        Console.WriteLine($"Each student gets {piecesPerStudent} slices.");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Hey smart pants, you didn't give me a number. I guess you don't want pizza!");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("zero students eh? No pizza for you");
        continueLoop = false;
    }
    catch (Exception ex) //generally not good practice - only want to throw exceptions you know how to handle 
    {
        Console.WriteLine($"An exception occurred: {ex.Message}");
        continueLoop = false; // throw ex; (application still crashes but logs as much info as possible)
    }
    // this is called swallowing an exception
    // catch (Exception ex)
    //{

    //}
    finally
    {
        //Close connection and files 
    }
}

//order of exceptions is important , will get an error if you'll never hit a certain exception 
Console.ReadKey();
