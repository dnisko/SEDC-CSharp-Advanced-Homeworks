using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using Task01.Models;

namespace Task01
{
    public class Program
    {
        #region Task01

        /*
        1. Filter all cars that have origin from Europe and print them in console.
        2. Filter all cars that have more than 6 Cylinders not including 6,
            after that Filter all cars that have exactly 4 Cylinders and have HorsePower more than 110.0.
            Join them in one result and print them in console.
        3. Count all cars based on their Origin and print the result in console. Example outpur "US 10 models\n Eu 15 Models";
        4. Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;
        5. Find the top 3 fastest accelerating cars:
        6. Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list. Print the model of each of these top 3 cars.
        7. Calculate the total weight of cars with more than 6 cylinders:
        8. Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight.
        9. Find the average MilesPerGalon for cars with even number of cylinders:
        10. Filter cars that have an even number of cylinders. Calculate the average MilesPerGalon for these cars. Print the average MilesPerGalon.
        
        Model = "Chevrolet Chevelle Malibu",
        MilesPerGallon = 18,
        AccelerationTime = 12,
        Cylinders = 8,
        HorsePower = 130,
        Origin = "US",
        Weight = 3504
         */

        #endregion
        static void Main(string[] args)
        {
            CarsData.LoadCars();
            List<Car> cars = CarsData.Cars;

            //1. Filter all cars that have origin from Europe and print them in console.
            Console.WriteLine("------------------------------ Query 1 ------------------------------");
            var query1 = cars.Where(x => x.Origin == "Europe").ToList();
            PrintInConsole(query1);

            //2. Filter all cars that have more than 6 Cylinders not including 6,
            //after that Filter all cars that have exactly 4 Cylinders and have HorsePower more than 110.0.
            //Join them in one result and print them in console.
            Console.WriteLine("\n------------------------------ Query 2 ------------------------------");
            //var query2_1 = cars.Where(x => x.Cylinders > 6).ToList();
            //var query2_2 = cars.Where(x => x.Cylinders == 4 && x.HorsePower >= 110).ToList();
            //var query2 = query2_1.Concat(query2_2).ToList();
            var query2 = cars.Where(x => x.Cylinders > 6 || x.Cylinders == 4 && x.HorsePower >= 110).ToList();
            PrintInConsole(query2);

            //3. Count all cars based on their Origin and print the result in console. Example output "US 10 models\n Eu 15 Models";
            Console.WriteLine("\n------------------------------ Query 3 ------------------------------");
            var query3 = cars.GroupBy(x => x.Origin)
                                                     .Select(x => new KeyValuePair<string, int>(x.Key, x.Count()));
            var query3_1 = cars.GroupBy(x => x.Origin)
                                                    .ToDictionary(x => x.Key, x => x.Count());
            foreach (var car in query3)
            {
                Console.WriteLine($"{car.Key} {car.Value} models");
            }
            foreach (var car in query3_1)
            {
                Console.WriteLine($"{car.Key} {car.Value} models");
            }

            //4. Filter all cars that have more than 200 HorsePower and Find out how much is the lowest, highest and average Miles per gallon and print them in console;
            Console.WriteLine("\n------------------------------ Query 4 ------------------------------");
            var query4 = cars.Where(x => x.HorsePower >= 200);
            var lowestQ4 = query4.Min(x => x.MilesPerGallon);
            var highestQ4 = query4.Max(x => x.MilesPerGallon);
            var averageQ4 = query4.Average(x => x.MilesPerGallon);
            Console.WriteLine($"Lowest: {lowestQ4}. Highest: {highestQ4}. Average: {averageQ4}");

            //5. Find the top 3 fastest accelerating cars:
            Console.WriteLine("\n------------------------------ Query 5 ------------------------------");
            var query5 = cars.OrderByDescending(x => x.AccelerationTime).Take(3).ToList();
            PrintInConsole(query5);

            //6. Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list. Print the model of each of these top 3 cars.
            Console.WriteLine("\n------------------------------ Query 6 ------------------------------");
            var query6 = cars.OrderBy(x => x.AccelerationTime).Take(3).ToList();
            PrintInConsole(query6);

            //7. Calculate the total weight of cars with more than 6 cylinders:
            Console.WriteLine("\n------------------------------ Query 7 ------------------------------");
            var query7 = cars.Where(x => x.Cylinders > 6).Select(x => x.Weight).Sum();
            Console.WriteLine($"Total weight of cars with more than 6 cylinders is: {query7}");

            //7 and 8 are the same query?

            //8. Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight.
            Console.WriteLine("\n------------------------------ Query 8 ------------------------------");
            Console.WriteLine($"Total weight of cars with more than 6 cylinders is: {query7}");

            //9. Find the average MilesPerGallon for cars with even number of cylinders:
            Console.WriteLine("\n------------------------------ Query 9 ------------------------------");
            var query9 = cars.Where(x => x.Cylinders % 2 == 0).Average(x => x.MilesPerGallon);
            Console.WriteLine($"Average Miles per gallon for cars with even no. of cylinders is: {query9}");

            //9 and 10 are the same query?

            //10. Filter cars that have an even number of cylinders. Calculate the average MilesPerGallon for these cars. Print the average MilesPerGallon.
            Console.WriteLine("\n------------------------------ Query 10 ------------------------------");
            Console.WriteLine($"Average Miles per gallon for cars with even no. of cylinders is: {query9}");
        }

        public static void PrintInConsole(List<Car> list)
        {
            foreach (var car in list)
            {
                Console.WriteLine(car.GetInfo());
                Console.WriteLine();
            }
        }
    }
}
