using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_10_w
{
    public class Car
    {
        public string CarName { get; set; }

    }
    public class Garage
    {
        public List<string> garage = new List<string>();

        public void garageAdd(Car car)
        {
            garage.Add(car.CarName);
        }
    }
    public class Washer
    {
        public void wash(string CarName)
        {
            Console.WriteLine($" Мы моем ваш {CarName}");
        }
    }
    internal class Program
    {
        public delegate void WashCars(string CarName);
        static void Main(string[] args)
        {
            Car mers = new Car();
            Car bmv = new Car();
            Car lada = new Car();

            mers.CarName = "Мурседес";
            bmv.CarName = "BMV";
            lada.CarName = "Лада";

            Garage garage = new Garage();
            garage.garageAdd(mers);
            garage.garageAdd(bmv);
            garage.garageAdd(lada);

            Washer washer = new Washer();

            WashCars washCars = new WashCars(washer.wash);

            foreach (var car in garage.garage)
            {
                washCars(car);
            }

            Console.ReadLine();
        }
    }
}
