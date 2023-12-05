namespace _01_CarManufacturer;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }
    public Engine Engine { get; set; }
    public List<Tire> Tires { get; set; }

    public Car()
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }

    public Car(string make, string model, int year)
        : this()
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, List<Tire> tires)
      : this(make, model, year, fuelQuantity, fuelConsumption)
    {
        Engine = engine;
        Tires = tires;
    }

    public void Drive(double distance)
    {
        double fuelCalculation = (FuelQuantity - distance) * FuelConsumption;
        if (fuelCalculation < 0)
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }

    }
    public string WhoAmI()
    {
        return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
    }
}
