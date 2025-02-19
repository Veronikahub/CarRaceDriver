public class RaceResult
{
    // Список для збереження результатів гонки
    private List<(Car car, int position, double time)> results = new List<(Car car, int position, double time)>();

    // Метод для визначення результатів гонки
    public void ResultsGonki(List<Car> cars)
    {
        var sortedCars = new List<Car>(cars);
        results.Clear();
        sortedCars.Sort((a, b) => b.Speed.CompareTo(a.Speed)); // Сортуємо автомобілі за швидкістю у порядку спадання (найшвидший — перший)

        for (int i = 0; i < sortedCars.Count; i++) // Додаємо результати в список (від першого до останнього місця)
        {
            double time = CalculateTime(sortedCars[i].Speed);  // час для проходження дистанції
            results.Add((sortedCars[i], i + 1, time));
        }
    }

    //метод для розрахунку часу гонки
    private double CalculateTime(int speed)
    {
        const double distance = 1000.0;
        return distance / (speed * 1000.0 / 3600.0);
    }

    public void Results() // Метод для виведення результатів гонки
    {
        Console.WriteLine("Результати гонки:");
        results.Sort((a, b) => a.time.CompareTo(b.time));

        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine($"{results[i].position}. {results[i].car.Brand} (Час: {results[i].time:F2} сек, Швидкість: {results[i].car.Speed} км/год)");
        }
    }
}