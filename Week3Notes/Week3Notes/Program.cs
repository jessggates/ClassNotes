
string friend1 = "Frank";
string friend2 = "Jeff";

string[] friends = new string[2];
string[] patFriends = new string[500]; // once its set you cant add more
// uses up memory - want to be as precise as possible to what will be used because they're saved for memory
// get filled up with default value of what you set up 


//can set something else equal to your array, but if creating new need to use the new 
//every intialize will need new keybord (reference types)
string[] jessFriends = patFriends;


int[] ages = new int[12];
bool[] drinksAlcohol = new bool[12];


int numberOfFriends = 12;
string[] oldFriends = new string[numberOfFriends];

// arrays are fixed length (their size cannot change, can't add or delete elements)

//arrays are zero-based index .. first element has an index of 0

int lastIndex = friends.Length - 1; // creates lastIndex to get easily
Console.WriteLine($"first {friends[0]}"); //gives the first element 
Console.WriteLine($"last{friends[lastIndex]}"); //the last element
Console.WriteLine(friends[14]); //doesn't know you dont have 14 friends...index out of range exception

string[] scottFriends = new string[2];
while (true)
{
    string[] newFriends = new string[34];
    friends.CopyTo( newFriends, lastIndex );
}


string[] newPersonFriends = new string[] { "Jeff", "Frank", "Stan", "Mary", "Beth" };

//element = the container in the array, the index is the address of that container, value is whats inside container
//int[] scores = new int[] { 90,65,85,80,75,65 };

scores[1] = 88;
int firstScore = scores[0];
int thirdScore = scores[2];

// for loop

for (int i =0; i < scores.Length; i++) // be careful of adding an = because .length needs to be 1 less
{
    Console.WriteLine(scores[i]);
} // this will print out the line of scores

for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine($"What is the name of friend #{i+1}");
    string input = Console.ReadLine();
    friends[i] = input;
}

// Foreach Loop
foreach(string friend in friends) //while this is looping, this value is changing for the string friend
{
    Console.WriteLine(friend);
}

foreach(int score in scores)
{
    Console.WriteLine(score);
}

int indexCounter = 0;
foreach (string friend in friends)
{
    Console.WriteLine($"What is the name of friend #{indexCounter + 1}?");
    string input = Console.ReadLine();
    friends[indexCounter] = input;
    indexCounter++;
}

bool isScottInvited = false;
foreach (string friend in friends)
{
    if(friend.ToLower() == "scott")
    {
        Console.WriteLine("unacceptable");
        break;
    }
}

Console.WriteLine("Got it");


Console.ReadKey();






int[] scores = new int[] { 90, 65, 85, 80, 75, 65 };

ModifyArray(scores);



void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.WriteLine(item);
    }
}

void ModifyArray(int[] array)
{
    int[] copiedArray = array; // points copiedArray to same spot in memory as array
    copiedArray[0] = -1; //scores[0] has been changed to -1
    int[] correctArray = new int[array.Length]; //this + below line is correct way to do this
    array.CopyTo(correctArray,0);
    correctArray[0] = -1; //this will only affect correctArray
}

/*void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.WriteLine(item);
    }
}*/

//cant overload - it has to be done in a class (overloading in program CS not allowed)


string[] friendFriends = new string[] { "Jeff", "Frank", "Stan", "Mary", "Stan", "Beth" };
string[] machineStatuses = new string[] { "Running", "Stopped", "Failed", "In Repair" };

Console.WriteLine(machineStatuses.Length);
Array.Sort(machineStatuses); //modifies the actual array
Array.Reverse(machineStatuses);

Array.Reverse(friend1.ToArray()); //reverse a string (a string is just an array of characters)

Array.Clear(machineStatuses); //reset all elements to the default of the type
Array.Clear(machineStatuses, 2, 2);


int firstIndex = Array.IndexOf(friendFriends, "Stan");
//scottFriends[firstIndex] = "cas";
if (firstIndex >= 0)
{
    scottFriends[firstIndex] = "Cas";
}
    //better defensive code



firstIndex = Array.IndexOf(friendFriends, "Gina"); //will return a -1 if not found



string[] listOfEngineers = new string[] { "Henry", "Adam", "Andy", "Ian" };
Console.WriteLine(new Random());
