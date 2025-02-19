public class Driver : Mashina
{
    //fields
    public string Name;

    public int Expirience;
    public int Rating;

    public Car Car { get; set; }

    //conctructor
    public Driver(string name, int rating, int expirience)
        : base(null, rating)
    {
        this.Name = name;
        this.Rating = rating;
        this.Expirience = expirience;
    }

    //methods
    public void UpgrateRating(int newRating)
    {
        rating = newRating; //рейтинг змінюється за підсумками гонки, тому потребує оновлення
    }

    public void GetCar(Car car)
    {
        this.Car = car;
    }

}