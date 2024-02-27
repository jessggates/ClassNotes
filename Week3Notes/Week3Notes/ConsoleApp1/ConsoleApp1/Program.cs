// notes on 2/7 

//Array
string[] myFavoriteMovies = new string[10];

//List
List<string> myFavoriteBooks = new List<string>(); //first part is declaring it, second part is initializing

List<string> myFavoriteGames = new List<string>() { "Clank", "Galaxy Trucker" };
//unlike arrays you can add a 4th 5th etc.. 
//have indexes like arrays, and have a 0 based index.. everything in c# is a zero based index


myFavoriteBooks.Add("To Kill a Mockingbird"); // adds to the end of the collection 
myFavoriteBooks.Add("1984");
myFavoriteBooks.Add("The Catcher in the Rye");

myFavoriteBooks.Insert(0, "The Great Gatsby"); //inserts it into whatever spot you want to insert 
myFavoriteBooks.Insert(3, "New Book");
myFavoriteBooks.InsertRange(2, myFavoriteGames); //can add another list w/ a range of where to add

myFavoriteBooks.AddRange(myFavoriteGames);


int numberOfBooks = myFavoriteBooks.Count;
int indexToRead = 1;

bool wasRemoved = myFavoriteBooks.Remove("Clank"); //this returns a bool (if this doesnt exist, itll return a false)

bool doesExist = myFavoriteBooks.Contains("Clank");
if (doesExist == false)
{
    Console.WriteLine("That book was not on the list.");
}

Console.WriteLine("Here is the book list");

for (int i = 0; i < myFavoriteBooks.Count; i++)
{
    Console.WriteLine($"({i+1}) - {myFavoriteBooks[1]}");
}

Console.WriteLine("Enter the number of the book you want to remove");
int indexToRemove = int.Parse(Console.ReadLine()) -1;
myFavoriteBooks.RemoveAt(indexToRemove);

Console.Clear();

Console.WriteLine("Here is the revised book list");


string one = "Scott";
string two = "scott";

if (string.Equals(one,two,StringComparison.OrdinalIgnoreCase))
{
    ///another way to ignore case?
}

myFavoriteGames.Clear();
myFavoriteGames.Count(); // this will equal 0   



if (wasRemoved == false)
{
    Console.WriteLine("That book was not on the list.");
}


if(indexToRead <= numberOfBooks)
Console.WriteLine(myFavoriteBooks[indexToRead]);


for (int i = 0; i < myFavoriteBooks.Count; i++)
{
    Console.WriteLine(myFavoriteBooks[i]);
}
// this will loop through the books


foreach (string book in myFavoriteBooks) 
{
    Console.WriteLine(book);
    //myFavoriteBooks.Add("Green Eggs and Ham"); - cant do this in here
}



//Dictionaries 

Dictionary<string,int> studentGrades = new Dictionary<string,int>();

Dictionary<string, string> capitals = new Dictionary<string, string> { { "Japan", "Tokyo" }, { "Moscow", "Russia" } }; //have to be smashed together so use extra curly braces
capitals.Add("France", "Paris");
capitals.Add("Italy", "Rome");

//the key for the dictionary is student ID 
Dictionary<int, string> studentNames = new Dictionary<int, string>();
studentNames.Add(123425, "John Doe");
studentNames.Add(231241, "Jane Smith");
// key gets turned into a hash which makes it easier to look up 

//cannot duplicate a key 


Dictionary<string, string> books = new Dictionary<string, string>();

books.Add("authorname", "titlename"); // this is a BAD dictionary because author can have multiple books
//better woud be 
books.Add("isbn", "titlename");


Console.WriteLine("What is your birthdate (mm/dd/yyyy)");
string input = Console.ReadLine();
string[] dateParts = input.Split("/");
int birthMonth = int.Parse(dateParts[0]);

Dictionary<int, string> months = new Dictionary<int, string>
{
    {1, "January" },
    {2, "February" },
    {3, "March" },
    {4, "April" }
};

Console.WriteLine($"You were born in the month of {months[birthMonth]}");

months.Remove(7); // this doesn't break if doesn't exit.. if you do have it to remove, it removes
months.Clear(); // this clears everything out 


Dictionary<string, int> lunchVotes = new Dictionary<string, int>()
{
    {"pizza", 0 },
    {"subs" ,0 },
    {"burgers" ,0 },
    {"salads" ,0 },
    {"lunchables" ,0 },
    {"yogurt" ,0 },
};

Console.WriteLine("What's for lunch today, here are the current votes");
foreach(KeyValuePair<string,int> item in lunchVotes) //can also use var keyword instead of KeyValuePair
{
    Console.WriteLine($"{item.Key} has {item.Value} votes");
}

Console.WriteLine("Here are the food options");
foreach(string item in lunchVotes.Keys)
{
    Console.WriteLine(item);
}

int tally = 0;
foreach(int item in lunchVotes.Values)
{
    tally = tally + item;
}

Console.WriteLine($"The total number of votes is {tally}");



Console.WriteLine("Enter the item you want");
input = Console.ReadLine();

if (lunchVoites.ContainsKey(input))
{
    Console.WriteLine("This does the same thing as below");
}

if (lunchVotes.Keys.Contains(input.ToLower()))
{
    lunchVotes[input.ToLower()]++;
}




AddStudent();
void AddStudent(int studentID, string studentName, Dictionary<int,string>collection)
{
    collection.Add(studentID, studentName);
}

