
using System;

public class Laptop : IConnectable, IRechargeable, IDisplayable
{
    public string Manufacturer { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryPercentage { get; private set; }

    public Laptop(string manufacturer)
    {
        Manufacturer = manufacturer;
        BatteryPercentage = 0;
    }

    public bool Connect()
    {
        IsConnected = true;
        Console.WriteLine($"Connected to {Manufacturer} Laptop.");
        return true;
    }

    public void Charge(int minutes)
    {
        if (BatteryPercentage < 100)
        {
            BatteryPercentage += minutes / 20;
            Console.WriteLine($"{Manufacturer} Laptop is charged. Battery Percentage: {BatteryPercentage}%");
        }
        else
        {
            Console.WriteLine($"{Manufacturer} Laptop is already fully charged.");
        }
    }

    public string Display()
    {
        return $"{Manufacturer} Laptop Display: {BatteryPercentage}% Battery";
    }
}
