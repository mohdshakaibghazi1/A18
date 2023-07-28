// Program.cs
using System;

public class Program
{
    public static void Main()
    {
        
        Smartphone samsungPhone = new Smartphone("Samsung");
        Laptop dellLaptop = new Laptop("Dell");

       
        samsungPhone.Connect();
        samsungPhone.Charge(980);
        Console.WriteLine(samsungPhone.Display());

        dellLaptop.Connect();
        dellLaptop.Charge(365);
        Console.WriteLine(dellLaptop.Display());
    }
}
