using System;


public class Transport
{
    protected double speed;
    protected double costPorKm;
    protected int passendgerCapacity;
    protected double cargoCapacity;

    protected Transport(double speed, double costPorKm, int passendgerCapacity, double cargoCapacity)
    {
        this.speed = speed;
        this.costPorKm = costPorKm;
        this.passendgerCapacity = passendgerCapacity;
        this.cargoCapacity = cargoCapacity;
    }

    public abstract double CalculateTime(double distance);
    public abstract double Calculatecost(double distance, int passendgers, double cargo);
}
class Car : Transport
{
    public Car() : base(80, 15, 4, 0.5) { }

    public override double CalculateTime(double distance)
    {
        return distance / speed; 
    }

    public override double CalculateCost(double distance, int passendgers, double cargo)
    {
        return (distance * costPorKm) + (passendgers * 100) + (cargo + 500);
    }
}