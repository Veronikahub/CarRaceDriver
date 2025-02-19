public class Driver : Mashina
{
    public string name;

    public int expirience;

     public Car Car { get; set; }


    public Driver(string name, int rating, int expirience)
        : base(null, rating)
    {
        this.name = name;
        this.rating = rating;
        this.expirience = expirience;
    }

    public void UpgrateRating(int newRating)
    {
        rating = newRating; //рейтинг змінюється за підсумками гонки, тому потребує оновлення
    }

    public void GetCar(Car car)
    {
        this.Car = car;
    }

}