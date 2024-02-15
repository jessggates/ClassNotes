
using UnitFourCode;

List<String> list = new List<string>();


Rectangle redRectangle = new Rectangle(Guid.NewGuid(), "red", 5.0, 3.0); 
Rectangle blueRectangle = new Rectangle(Guid.NewGuid(), "blue", 6.0, 4.0); //these are separate objects, have nothing to do with each other 

redRectangle.Color = "purple"; // this would change the object 
blueRectangle.DisplayDetails();
redRectangle.DisplayDetails();

Console.ReadKey();


