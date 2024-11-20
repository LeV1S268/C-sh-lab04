/*using System;
using System.Collections.Generic;
public class Car
{
    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public int MaxSpeed { get; set; }
    public Car(string name, int year, int speed)
    {
        Name = name;
        ProductionYear = year;
        MaxSpeed = speed;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Year: {ProductionYear}, MaxSpeed: {MaxSpeed}";
    }
}
public class CarComparer : IComparer<Car>
{
    public enum SortBy { Name, ProductionYear, MaxSpeed }
    private SortBy sortBy;
    public CarComparer(SortBy sortBy)
    {
        this.sortBy = sortBy;
    }
    public int Compare(Car x, Car y)
    {
        if (x == null || y == null)
            throw new ArgumentException("Objects to compare cannot be null");

        switch (sortBy)
        {
            case SortBy.Name:
                return string.Compare(x.Name, y.Name);
            case SortBy.ProductionYear:
                return x.ProductionYear.CompareTo(y.ProductionYear);
            case SortBy.MaxSpeed:
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            default:
                throw new ArgumentException("Invalid sorting option");
        }
    }
}
class Program
{
    static void Main()
    {
        Car[] cars = {
            new Car("Toyota", 2015, 180),
            new Car("BMW", 2020, 240),
            new Car("Audi", 2018, 220),
            new Car("Ford", 2010, 160)
        };
        Array.Sort(cars, new CarComparer(CarComparer.SortBy.Name));
        Console.WriteLine("Сортировка по имени:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
        Array.Sort(cars, new CarComparer(CarComparer.SortBy.ProductionYear));
        Console.WriteLine("\nСортировка по году выпуска:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
        Array.Sort(cars, new CarComparer(CarComparer.SortBy.MaxSpeed));
        Console.WriteLine("\nСортировка по максимальной скорости:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
*/