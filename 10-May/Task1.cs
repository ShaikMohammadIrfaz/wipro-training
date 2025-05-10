using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Operating appliance");
    }
}

class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes");
    }
}
