public class Track
{
    public Car[] cars; //створення масиву, що буде зберыгати об'єкти
    public int counterCar; 

    //conctructor
    public Track()
    {
        cars = new Car[2];  //створення масиву певної довжини
        counterCar = 0; 
    }


    public void AddCar(Car car)
    {
        if (counterCar < 2) 
        {
            cars[counterCar] = car; 
            counterCar++; 
        }
        else
        {
            Console.WriteLine("Лімітна кількість машин вичерпана"); 
        }
    }


    //запуск гонки
    public RaceResult StartRace()
    {
        RaceResult raceResult = new RaceResult();
        raceResult.ResultsGonki(new List<Car>(cars.Take(counterCar)));
        return raceResult;
    }
}