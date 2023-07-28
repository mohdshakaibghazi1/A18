// Smartphone.cs
using System;

public class Smartphone : IConnectable, IRechargeable, IDisplayable
{
    public string Brand { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryPercentage { get; private set; }

    public Smartphone(string brand)
    {
        Brand = brand;
        BatteryPercentage = 0;
    }

    public bool Connect()
    {
        IsConnected = true;
        Console.WriteLine($"Connected to {Brand} Smartphone.");
        return true;
    }

    public void Charge(int minutes)
    {
        if (BatteryPercentage < 100)
        {
            BatteryPercentage += minutes / 10;
            Console.WriteLine($"{Brand} Smartphone is charged. Battery Percentage: {BatteryPercentage}%");
        }
        else
        {
            Console.WriteLine($"{Brand} Smartphone is already fully charged.");
        }
    }

    public string Display()
    {
        return $"{Brand} Smartphone Display: {BatteryPercentage}% Battery";
    }
}
