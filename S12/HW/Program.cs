namespace Class;

class Program
{
    static void Main(string[] args)
    {
        IVehicles mybike = new Bike();
        IVehicles mycar = new Car();
        Console.WriteLine(mycar.Seat_number());
        Console.WriteLine(mybike.SteadyCeiling());


    }
}
