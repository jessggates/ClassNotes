
using Week6Notes;


Console.WriteLine("What day do you want to go to the store? (0-6)");
int inputTwo = int.Parse(Console.ReadLine());
DayOfWeek dayOfWeek = (DayOfWeek)input;

switch (dayOfWeek)
{
    case DayOfWeek.Monday:
    case DayOfWeek.Tuesday:
    case DayOfWeek.Wednesday:
        Console.WriteLine("ugh");
        break;
    case DayOfWeek.Thursday:
        Console.WriteLine("happy thursday");
        break;
    case DayOfWeek.Friday:
        Console.WriteLine("yay friday");
        break;
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("weekend");
        break;
    default: //dont really need the default because it wont come to this with the enums available 
        Console.WriteLine("That is not a valid day of the week");
        break;
}



Console.WriteLine("what music genre do you listen to?");
string input = Console.ReadLine();



DayOfWeek weekDay = DayOfWeek.Monday;
DayOfWeek tomorrow = DayOfWeek.Tuesday;


//this is what it would look like w/o using enums
int dayNumberOfWeek = 1;
int tomorrowDayNumber = 2;

switch (dayNumberOfWeek)
{
    case 1:
        Console.WriteLine("ugh monday");
        break;
    case 2:
        Console.WriteLine("tuesday");
        break;
    default:
        Console.WriteLine("no idea what day it is");
        break;
}

//this is what it looks like using enums 

switch (weekDay)
{
    case DayOfWeek.Monday:
    case DayOfWeek.Tuesday:
    case DayOfWeek.Wednesday:
        Console.WriteLine("ugh");
        break;
    case DayOfWeek.Thursday:
        Console.WriteLine("happy thursday");
        break;
    case DayOfWeek.Friday:
        Console.WriteLine("yay friday");
        break;
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("weekend");
        break;
}

// MusicGenre genre = new MusicGenre(); don't want to do this, it just makes another genre 

if (IsValidEnumOption(input, out MusicGenre userGenre))
{
    Console.WriteLine($"You are good to listen to {userGenre}");
}
else
{
    Console.WriteLine("That is not a valid genre");
}


bool IsValidEnumOption(string genreInput, out MusicGenre validGenre)
{
    bool isEnum = Enum.TryParse(genreInput, true, out validGenre);
    bool isValidChoice = Enum.IsDefined(typeof(MusicGenre), validGenre);
    return isEnum && isValidChoice;
}