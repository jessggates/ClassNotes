// inheritance (classes inherit characteristics from other classes

//increase maintainability & removes duplication of data

// use "is a" mentality to decide whether something should be inherit something else 


using Week5Part2;

Bird bigBird = new Bird();

bigBird.Age  = 10;
bigBird.Weight = 12.20;
bigBird.Fly();
bigBird.Speak(); // returns im an animal rrr.


Fish oscar = new Fish(); //becomes a thing once we use this new keyword
oscar.Sleep();
oscar.GillType = "standard";
string speakMessage = oscar.Speak(); //returns glub glub 


Animal animal = new Animal();
animal.Age = 10;

Raptor falcon = new Raptor();
falcon.Name = "Blue Falcon";




//Person
//Employee
//Customer
//Contractor
//Manager

HourlyEmployee cashier = new HourlyEmployee("Stan", "345hgt", 12.50);
Contractor janitory = new Contractor("Jeff", "1234asd", 450);
Manager boss = new Manager("Cassley", "45a4sd", 254000);

cashier.CalculatePay();

DisplayInfoClass displayInfo = new DisplayInfoClass();

displayInfo.Show("test");
displayInfo.Show("est", 12);
displayInfo.Show("sda", 13, 1323);