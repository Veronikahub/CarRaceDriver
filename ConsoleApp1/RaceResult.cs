public class RaceResult
{
    // Список для збереження результатів гонки (машина та її позиція)
    private List<(Car car, int position)> results = new List<(Car, int)>();

    // Метод для визначення результатів гонки
    public void ResultsGonki(List<Car> cars)
    {
        // Створюємо копію списку автомобілів, щоб не змінювати вихідний список
        var sortedCars = new List<Car>(cars);

        // Сортуємо автомобілі за швидкістю у порядку спадання (найшвидший — перший)
        sortedCars.Sort((a, b) => b.Speed.CompareTo(a.Speed));

        // Очищаємо список перед новою гонкою
        results.Clear(); 

        // Додаємо результати в список (від першого до останнього місця)
        for (int i = 0; i < sortedCars.Count; i++)
        {
            results.Add((sortedCars[i], i + 1)); 
        }
    }

    // Метод для виведення результатів гонки
    public void Results()
    {
        Console.WriteLine("Результати гонки:");
        foreach (var result in results)
        {
            Console.WriteLine($"{result.position}. {result.car.Brand} (Швидкість: {result.car.Speed} км/год)");
        }
    }
}