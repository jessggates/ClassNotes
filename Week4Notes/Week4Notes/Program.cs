//LINQ 

// simple anonymous function 

using System.Globalization;

int Multiply(int x)
{
    return x * x;
}

// => fat arrow 

// (input parameters) => expression;
// x => x * x; // lambda function 

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 12, 13, 14, 12, 16 };
numbers.Max();
List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0).Where(x => x > 10).Distinct().ToList(); //(would need to change to var to check if right)
// to list will take the enumerable and cast it as a list
// lambda function is an in line loop (does more than just looping but goes through entire collection and runs expression on element)


string[] names = new string[] {"John", "James", "Joey", "Jason", "Jeff" };
List<string> nameList = new List<string>(); /// can add additional fields to a list 
nameList.AddRange(names);
List<string> jNames = names.Where(x => x.StartsWith("J")).OrderBy(x => x).ToList(); // to array go into a string... etc. can choose how you want to display it   .OrderBy() can be used for more than 1 element, Sort() if 1 element
// also OrderbyDescending() or OrderByAscending()

//with query syntax
var namesWithQuery = from name in names
                     where name.StartsWith("A") && name.EndsWith("a")
                     select name;


// more examples from LINQ lab 


int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//minimum value
int min = nums.Min();
//maximum value
int max = nums.Max();
//find the max value less than 10000
int newMax = nums.Where(x => x < 10000).Max();
//find all the values between 10 and 100
int[] lowNumbers = nums.Where(x => x > 10 && x < 100).ToArray();
//find all between 100000 and 999999 inclusive
int[] highNumbers = nums.Where(x => x >= 100000 && x <= 999999).ToArray();
//count all the even numbers 
int evenNumberCount = nums.Where(x => x % 2 == 0).Count();



Console.ReadKey(); //can set a break point here and watch your code run in the locals (debug, windows, local -- code must be running to use) 














