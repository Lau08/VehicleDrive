

using VehicleDrive.Models;
using System;
using System.IO;

public class Program
{
    static void Main()
    {
        System.Timers.Timer timer = new(interval: 5000);
        Console.WriteLine("Here is your new car: ");
        Console.WriteLine("     _______");
        Console.WriteLine(" ___/ _____ \\___");
        Console.WriteLine("/___\\\' .-. '/___\\");
        Console.WriteLine("  \\__/   \\__/");
        Console.WriteLine("");
        Console.WriteLine("Enter the amount of gasoline to start driving: ");
        string enteredString = Console.ReadLine();
        RefuelCar(enteredString);
    }

    static void RefuelCar(string enteredString)
    {
        if (enteredString != null)
        {
            try
            {
                int fuelAmount = int.Parse(enteredString);
                Car car = new Car(fuelAmount);
                car.Drive();
                Console.WriteLine("                         _______");
                Console.WriteLine("                     ___/ _____ \\___");
                Console.WriteLine("      ,.,.,.,.,.,., /___\\\' .-. '/___\\");
                Console.WriteLine("____________________  \\__/   \\__/");
                Console.WriteLine("");
                car.SetFuel(0);
                car.Drive();
                Console.ReadLine();
            } catch (FormatException e)
            {
                Console.WriteLine($"{e.Message}");
                Console.WriteLine("Enter the amount of gasoline to start driving: ");
                string enteredamount = Console.ReadLine();
                RefuelCar(enteredamount);
            }
        }
        else
        {
            Console.WriteLine("Enter the amount of gasoline to start driving: ");
            string enteredamount = Console.ReadLine();
            RefuelCar(enteredamount);
        }
    }
}
