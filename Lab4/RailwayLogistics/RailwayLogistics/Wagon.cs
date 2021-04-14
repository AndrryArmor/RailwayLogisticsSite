using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Wagon
    {
        public Wagon()
        {
        }

        public Wagon(int weight, int maximumWeight, int volume) : this()
        {
            Weight = weight;
            MaximumWeight = maximumWeight;
            Volume = volume;
        }

        public Wagon(Wagon other) : this(other.Weight, other.MaximumWeight, other.Volume)
        {
        }

        public int Weight { get; set; }
        public int MaximumWeight { get; set; }
        public int Volume { get; set; }

        public static List<Wagon> operator +(Wagon wagonLeft, Wagon wagonRight)
        {
            var wagons = new List<Wagon>();
            wagons.Add(wagonLeft);
            wagons.Add(wagonRight);
            Console.WriteLine("Створено список з 2 вагонів");
            return wagons;
        }

        public static List<Wagon> operator +(List<Wagon> wagons, Wagon wagon)
        {
            var newWagons = new List<Wagon>(wagons);
            newWagons.Add(wagon);
            Console.WriteLine("Створено список зі списку і вагона");
            return newWagons;
        }
    }
}
