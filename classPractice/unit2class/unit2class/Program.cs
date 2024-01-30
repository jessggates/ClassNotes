//Exercise 1.1: Echo String
Console.WriteLine("Enter your name!");
string userName = Console.ReadLine();
Console.WriteLine(userName);

Console.ReadKey(); // keeps it from closing out

//Exercise 1.2: Adding a number to an integer
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number+1);

//Exercise 1.3 Adding a number to a float
Console.WriteLine("Enter a number");
float numberPlusPointFive = float.Parse(Console.ReadLine() + .5);
Console.WriteLine(numberPlusPointFive);

//Excercise 1.4: Adding Two Floats
Console.WriteLine("Enter a number:");
float firstNumber = float.Parse(Console.ReadLine());
Console.WriteLine("Enter another number:");
float secondNumber = float.Parse(Console.ReadLine());
Console.WriteLine("The number is " + (firstNumber+secondNumber));




