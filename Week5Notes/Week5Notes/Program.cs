

// state of the object = the values of these properties 
//data hiding is restricting direct access to the 'state' to the data itself 
//enhanaces modularity of the code, by keeping data and operations closer 
//encapsultion is only things having to do with the thing going in there 

// protect data with the private keywords, public can actually access that data 

using Week5Notes;

Car myCar = new Car();
myCar.Color = "purple";
myCar.Accelerate();

Account newAccount = new Account(3000);

Console.WriteLine("How much would you like to deposit?");
int amount = int.Parse(Console.ReadLine());

//User user = new User();
//Console.WriteLine(user.Name); //triggers the get
//user.Name = "Scott"; //triggers the get, and scott is the value you want the set to use



List<User> users = new List<User>();
users.Add(new User("john smith", "kk@ll.com", "1234"));
users.Add(new User("john jones", "here", "1234"));
users.Add(new User("mary smith", "kk@ll.com", "1234"));
users.Add(new User("frank franks", "there", "1234"));

var johns = users.Where(x => x.Name.ToLower().Contains("john")); //can also add List<User> and .ToList() at end to make a list of it
var badEmails = users.Where(x => x.Email == "bad@email.com");

Dictionary<string, User> userCollection = new Dictionary<string, User>();
User scottUser = new User("Scott", "Scott@here.com", "NZT221");
User casUser = new User("Cassley", "Cas@here.com", "CVTR55");

userCollection.Add(scottUser.UserID, scottUser);
userCollection.Add(casUser.UserID, casUser);

Console.WriteLine("Give me the user id for the employee you want to email");
string input = Console.ReadLine();
Console.WriteLine($"Great! That user's email is {userCollection[input].Email}");
if (userCollection.ContainsKey(input) == false)
{
    Console.WriteLine("That user does not exist");
}




foreach (User user in johns)
{
    Console.WriteLine(user.Name);
}
Console.WriteLine($"There are {badEmails.Count()} bad emails.");




try
{
    newAccount.Deposit(amount);
}
catch (ArgumentException)
{
    Console.WriteLine("You have to enter something greater than zero");
}

decimal newBalance = newAccount.GetBalance();
Console.WriteLine($"You have deposited your money. Your balance is {newBalance}");






Console.ReadKey();