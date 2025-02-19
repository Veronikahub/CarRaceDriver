using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть ім'я першого гонщика: ");
        string? userDriverName1 = Console.ReadLine();

        Console.Write("Введіть ім'я другого гонщика: ");
        string? userDriverName2 = Console.ReadLine();

 
        Driver driver1 = new Driver(userDriverName1, 57, 7);
        Driver driver2 = new Driver(userDriverName2, 44, 5);

        Car car1 = new Car("Audi", "12", 155, 5);
        Car car2 = new Car("BMW", "17", 140, 3);


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

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        LoadingAnimation("Обробка результатів гонки", 1);
        Console.ResetColor();

        RaceResult raceResult = track.StartRace();
        raceResult.Results();



        driver1.UpgrateRating(62);
        driver2.UpgrateRating(60);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Інформація про гонщиків після гонки:");
        Console.ResetColor();
        DriverInfoAfter(driver1);
        DriverInfoAfter(driver2); 
    }
     
     // метод для анімації "очікування результатів"
    public static void LoadingAnimation(string message, int durationSec)
    {
        Console.Write(message);
        int duration = durationSec * 5; //множення анімації на 5

        for (int i = 0; i < duration; i++)
        {
            Console.Write("🚗");
            Thread.Sleep(300); // Затримка крапок
        }
        
        Console.WriteLine();
    }

    public static void DriverInfoBefore(Driver driver)
    {
        Console.WriteLine($"Гонщик: {driver.Name}, Рейтинг: {driver.Rating}, Досвід: {driver.Expirience} років");
        driver.Car.CarShowInfo();
    }


    public static void DriverInfoAfter(Driver driver)
    {
        Console.WriteLine($"Гонщик: {driver.Name}, Рейтинг: {driver.Rating}, Досвід: {driver.Expirience} років");
        
    }
}