using _01_CarManufacturer;

//defining instances for Tire
var tires = new List<Tire>()
{
    new Tire(1, 2.5),
    new Tire(1, 2.1),
    new Tire(2, 0.5),
    new Tire(2, 2.3)
};

//defining instances for Engine
var engine = new Engine(560, 6300);

//defining instances for Car
var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

Console.WriteLine(car.WhoAmI());

//defining distance
car.Drive(2000);

