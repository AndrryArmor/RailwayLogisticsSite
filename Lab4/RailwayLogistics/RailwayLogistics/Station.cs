using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Station
    {
        public Station()
        {
            Wagons = new List<Wagon>();
            Locomotives = new List<Locomotive>();
        }

        public Station(string name, IEnumerable<Wagon> wagons, IEnumerable<Locomotive> locomotives) : this()
        {
            Name = name;
            Wagons.AddRange(wagons);
            Locomotives.AddRange(locomotives);
        }

        public Station(Station other) : this(other.Name, other.Wagons, other.Locomotives)
        {
        }

        public string Name { get; set; }
        public List<Locomotive> Locomotives { get; set; }
        public List<Wagon> Wagons { get; set; }
    }
}
