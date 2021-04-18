using System;
using System.Collections.Generic;

namespace DriverExercise
{
    class Program
    {
        static void Main(string[] args)
       
         {

            Car[] cars = new Car[]
            {
                new Car("Volkswagen", 20),
                new Car("Porsche", 21),
                new Car("Jaguar", 20),
                new Car("Maserati", 23),
            };

            Driver[] drivers = new Driver[]
            {
                new Driver("Damjan", 11),
                new Driver("Sashka", 10),
                new Driver("Trajan", 9),
                new Driver("Jovana", 10),
            };
            Car firstCar;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Choose the first car, by entering the car id ");
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine($"#{i + 1}: {cars[i].Model}");
                    }
                    bool IsValidInputFirstCar = int.TryParse(Console.ReadLine(), out int carSelectionId);
                    if (IsValidInputFirstCar && carSelectionId < 5)
                    {
                        firstCar = cars[carSelectionId - 1];
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Choose the first driver, by entering the driver id");
                    for (int i = 0; i < drivers.Length; i++)
                    {
                        Console.WriteLine($"#{i + 1}: {drivers[i].Name}");
                    }
                    bool IsValidInputFirstCar = int.TryParse(Console.ReadLine(), out int driverSelectionId);
                    if (IsValidInputFirstCar && driverSelectionId < 5)
                    {
                        firstCar.Driver = drivers[driverSelectionId - 1];
                        break;
                    }
                }
                Car secondCar;
                while (true)
                {
                    Console.WriteLine("Choose the second car, by entering the car id");
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Model == firstCar.Model)
                        {
                            continue;
                        }
                        Console.WriteLine($"#{i + 1}: {cars[i].Model}");
                    }
                    bool IsValidSecondCar = int.TryParse(Console.ReadLine(), out int carSelectionId);
                    if (IsValidSecondCar && carSelectionId < 5)
                    {
                        secondCar = cars[carSelectionId - 1];
                        if (secondCar.Model == firstCar.Model)
                        {
                            Console.WriteLine("This car is already used, please select another car");
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                while (true)
                {
                    Console.WriteLine("Choose the second driver, by entering the driver id");
                    for (int i = 0; i < drivers.Length; i++)
                    {
                        if (drivers[i].Name == firstCar.Driver.Name)
                        {
                            continue;
                        }
                        Console.WriteLine($"#{i + 1}: {drivers[i].Name}");
                    }
                    bool IsValidInputSecondCar = int.TryParse(Console.ReadLine(), out int driverSelectionId);
                    if (IsValidInputSecondCar && driverSelectionId < 5)
                    {
                        secondCar.Driver = drivers[driverSelectionId - 1];
                        if (secondCar.Driver == firstCar.Driver)
                        {
                            Console.WriteLine("This driver is already selected, please select another driver");
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                RaceCars(firstCar, secondCar);

                Console.WriteLine("Enter Y / N if you want to race again or to exit the app");
                if (!(Console.ReadLine().ToLower() == "Y".ToLower()))
                {
                    break;
                }

            }
            static void RaceCars(Car firstCar, Car secondCar)
            {
                int firstCarSpeed = firstCar.CalculateSpeed();
                int secondCarSpeed = secondCar.CalculateSpeed();

                if (firstCarSpeed > secondCarSpeed)
                {
                    Console.WriteLine($"{firstCar.Driver.Name} won the race driving a {firstCar.Model}. They were going {firstCarSpeed}");
                }
                else if (firstCarSpeed < secondCarSpeed)
                {
                    Console.WriteLine($"{secondCar.Driver.Name} won the race driving a {secondCar.Model}. They were going {secondCarSpeed}");
                }
                else
                {
                    Console.WriteLine($"What a close race by {firstCar.Driver.Name} and {secondCar.Driver.Name} it's A TIE! ");
                }
            }
        }
            
    }
}

