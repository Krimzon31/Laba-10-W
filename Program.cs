using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laba_10_w.Washer;

namespace Laba_10_w
{
    public class Car
    {
        public string CarName { get; set; }

    }
    public class Garage
    {
        public List<Car> garage = new List<Car>();

    }
    public class Washer
    {
        public delegate void WashCars(Car car);

        public WashCars washCars = new WashCars(wash);
        public static void wash(Car car)
        {
            Console.WriteLine($" Мы моем ваш {car.CarName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mers = new Car();
            Car bmv = new Car();
            Car lada = new Car();

            mers.CarName = "Мурседес";
            bmv.CarName = "BMV";
            lada.CarName = "Лада";

            Garage garage = new Garage();
            garage.garage.Add(mers);
            garage.garage.Add(bmv);
            garage.garage.Add(lada);

            Washer washer = new Washer();

            foreach (var car in garage.garage)
            {
                washer.washCars(car);
            }

            Console.ReadLine();
        }
    }
}
