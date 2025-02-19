using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введіть ім'я першого гонщика: ");
        string? userDriverName1 = Console.ReadLine();

        Console.Write("Введіть ім'я другого гонщика: ");
        string? userDriverName2 = Console.ReadLine();

 
        Driver driver1 = new Driver(userDriverName1, 57, 7);
        Driver driver2 = new Driver(userDriverName2, 44, 5);

        Car car1 = new Car("BMW", "12", 155, 5);
        Car car2 = new Car("Audi", "17", 140, 3);


        driver1.GetCar(car1);
        driver2.GetCar(car2);

        Track track = new Track();
        track.AddCar(car1);
        track.AddCar(car2);

        

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Інформація про гонщиків до гонки:");
        Console.ResetColor();
        DriverInfoBefore(driver1);
        DriverInfoBefore(driver2);




        RaceResult raceResult = new RaceResult();
        raceResult.ResultsGonki(new List<Car> { car1, car2 });

        
        raceResult.Results();


        driver1.UpgrateRating(62);
        driver2.UpgrateRating(60);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Інформація про гонщиків після гонки:");
        Console.ResetColor();
        DriverInfoAfter(driver1);
        DriverInfoAfter(driver2); 
    }



    public static void DriverInfoBefore(Driver driver)
    {
        Console.WriteLine($"Гонщик: {driver.Name}, Рейтинг: {driver.Rating}, Досвід: {driver.Expirience}");
        driver.Car.CarShowInfo();
    }


    public static void DriverInfoAfter(Driver driver)
    {
        Console.WriteLine($"Гонщик: {driver.Name}, Рейтинг: {driver.Rating}, Досвід: {driver.Expirience}");
        
    }
}