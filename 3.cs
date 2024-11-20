/*using System;
using System.Collections;
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

public class CarCatalog : IEnumerable<Car>
{
    private Car[] cars;
    public CarCatalog(Car[] cars)
    {
        this.cars = cars;
    }

    // Прямой проход (с первого элемента до последнего)
    public IEnumerable<Car> GetCarsDirect()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            yield return cars[i];
        }
    }

    // Обратный проход (с последнего элемента к первому)
    public IEnumerable<Car> GetCarsReverse()
    {
        for (int i = cars.Length - 1; i >= 0; i--)
        {
            yield return cars[i];
        }
    }

    // Фильтр по году выпуска
    public IEnumerable<Car> GetCarsByYear(int year)
    {
        foreach (var car in cars)
        {
            if (car.ProductionYear == year)
            {
                yield return car;
            }
        }
    }

    // Фильтр по максимальной скорости
    public IEnumerable<Car> GetCarsBySpeed(int minSpeed)
    {
        foreach (var car in cars)
        {
            if (car.MaxSpeed > minSpeed)
            {
                yield return car;
            }
        }
    }

    // Реализация интерфейса IEnumerable<Car> для использования foreach по умолчанию
    public IEnumerator<Car> GetEnumerator()
    {
        return ((IEnumerable<Car>)cars).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
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

        // Создание каталога автомобилей
        CarCatalog carCatalog = new CarCatalog(cars);

        // Прямой проход
        Console.WriteLine("Прямой проход:");
        foreach (var car in carCatalog.GetCarsDirect())
        {
            Console.WriteLine(car);
        }

        // Обратный проход
        Console.WriteLine("\nОбратный проход:");
        foreach (var car in carCatalog.GetCarsReverse())
        {
            Console.WriteLine(car);
        }

        // Проход с фильтром по году выпуска (например, 2018)
        Console.WriteLine("\nПроход по году выпуска (2018):");
        foreach (var car in carCatalog.GetCarsByYear(2018))
        {
            Console.WriteLine(car);
        }
         
        // Проход с фильтром по максимальной скорости (например, выше 200)
        Console.WriteLine("\nПроход по максимальной скорости (более 200):");
        foreach (var car in carCatalog.GetCarsBySpeed(200))
        {
            Console.WriteLine(car);
        }
    }
}
*/