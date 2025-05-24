namespace Class{
public interface IVehicles
{
 public int Wheel_number();
 public int Seat_number();
 public bool SteadyCeiling();



}
class Car:IVehicles
{
    public int Wheel_number()
    {
        return 4;
    }
    public int Seat_number()
    {
        return 5;
    }
    public bool SteadyCeiling()
    {
        return true;
    }



}
class Bus:IVehicles
{
    public int Wheel_number()
    {
        return 4;
    }
    public int Seat_number()
    {
        return 25;
    }
    public bool SteadyCeiling()
    {
        return true;
    }
}
class Carbio:IVehicles
{
    public int Wheel_number()
{
    return 4;
}
public int Seat_number()
{
    return 5;
}
public bool SteadyCeiling()
{
    return false;
}
}
class Bike:IVehicles
{
    public int Wheel_number()
{
    return 2;
}
public int Seat_number()
{
    return 1;
}
public bool SteadyCeiling()
{
    return false;
}
}
}