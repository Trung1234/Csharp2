using System;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;
           

            var Car2 = new Car("Red", 2008);
            var Car3 = new Car("Blue", 2018);

            var Car4 = new Car();
            // Using dot notation to call members on Car1
            Car4.Color = "White";
            Car4.Year = 2010;
            Car4.Brand = "Toyota";
            Car4.Mileage = 11000;
            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");

            Console.WriteLine($"Car Infor:   {Car4.Info()} ");
        }
    }
    public class Car
    {
    private static int count = 0;
    private string brand;
    private string color;
    private int year;
    private int mileage;
    public Car()
    {
        count++;     
    }
    public Car(string color,int year)
    {
        this.color = color;
        this.year = year;
        count++;
    }
    public static int CountCars(){
        return count;
    }
    public  string Info()
    {
        return "Name: " + brand + " Color: " +color;
    }
    // use properties!
    public string Brand{ get {return brand;} set { brand= value;} }
    public string Color{ get {return color;} set { color= value;} }
    public int Year { get {return year;} set { year = value;} }
    public int Mileage { get {return mileage;} set { mileage= value;} }
    }
    
}


