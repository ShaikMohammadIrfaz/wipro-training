using System;

class PowerCalculation
{
    public void Power(int baseValue, int exponent)
    {
        Console.WriteLine($"{baseValue}^{exponent} = {Math.Pow(baseValue, exponent)}");
    }

    public void Power(double baseValue, double exponent)
    {
        Console.WriteLine($"{baseValue}^{exponent} = {Math.Pow(baseValue, exponent)}");
    }
}

class Program
{
    static void Main()
    {
        PowerCalculation powerCalc = new PowerCalculation();
        powerCalc.Power(2, 2);       
        powerCalc.Power(5.5, 2);      
    }
}
