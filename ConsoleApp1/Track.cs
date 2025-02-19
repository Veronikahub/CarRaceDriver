public class Track
{
    public Car[] cars; 
    public int counterCar; 


    public Track()
    {
        cars = new Car[2]; 
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


    public Car[] GetCars()
    {
        return this.cars; 
    }
}