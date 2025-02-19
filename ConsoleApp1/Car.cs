public class Car : Mashina
{
    // Номер автомобіля
    public string NumberOfCar { get; set; }
    
    // Швидкість автомобіля
    public int Speed { get; set; }

    // Обсяг пального (літри)
    public int Toplivo { get; set; }

    // Конструктор класу Car, який успадковується від Mashina
    public Car(string Brand, string NumberOfCar, int Speed, int Toplivo)
        : base(Brand, 0) // Викликаємо базовий конструктор (з брендом та рейтингом)
    { 
        this.Brand = Brand;
        this.NumberOfCar = NumberOfCar;
        this.Speed = Speed;
        this.Toplivo = Toplivo;
    }

    // Метод для виведення інформації про автомобіль
    public void CarShowInfo()
    {
        Console.Write("Інформація про машину: ");
        Console.Write($"Бренд: {Brand}, ");
        Console.Write($"Номер: {NumberOfCar}, ");
        Console.Write($"Швидкість: {Speed} км/год, ");
        Console.Write($"Пальне: {Toplivo} л.");
        Console.WriteLine();
    }
}

// Базовий клас Машина
public class Mashina
{
    public string Brand;  // Назва бренду
    public int rating;   // Рейтинг машини (можливо, потрібно буде використовувати)

    // Конструктор класу Mashina
    public Mashina(string brand, int rating)
    {
        this.Brand = brand;
        this.rating = rating;
    }
}
