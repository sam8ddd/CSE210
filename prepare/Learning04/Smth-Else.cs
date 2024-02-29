using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("hi :)");
    }
}

class Vehicle
{
    protected string make;
    protected string model;
    protected float miles;

    public Vehicle(string _make, string _model, float _miles)
    {
        make = _make;
        model = _model;
        miles = _miles;
    }
}

class Car: Vehicle
{
    public Car(string _make, string _model, float _miles): base(_make, _model, _miles)
    {
    }
}

class Truck: Vehicle
{
    private int load;

    public Truck(string _make, string _model, float _miles, int _load): base(_make,_model,_miles)
    {
        load = _load;
    }
}