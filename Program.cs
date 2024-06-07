using STO;
using System;

class Program
{
    static void Main() 
    {
        var tiStation = new TiStation(); 

        tiStation.AddCar(new Car("A111AA", DateTime.Now.AddDays(3), "Автомат")); 
        tiStation.AddCar(new Car("B222BB", DateTime.Now.AddDays(1), "Механика"));
        tiStation.AddMotorcycle(new Motorcycle("C333CC", DateTime.Now.AddDays(2), "Спортивный"));
        tiStation.AddMotorcycle(new Motorcycle("D444DD", DateTime.Now.AddDays(5), "Классика"));
        tiStation.AddMotorcycle(new Motorcycle("E555EE", DateTime.Now.AddDays(4), "Чоппер"));

        foreach (var vehicle in tiStation.Schedule())
        {
            Console.WriteLine($"vehicle.GovNumber  -  vehicle.TiData.ToString("dd.MM.yyyy")"); 
        }
        Console.ReadKey();
    }
}
