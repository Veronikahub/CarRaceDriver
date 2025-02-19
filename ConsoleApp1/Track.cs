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


    public Car[] GetCars() //повернення масиву cars з метою отримання доступу до авто в Track
    {
        return this.cars; 
    }
}