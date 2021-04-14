using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Train
    {
        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public Train(Locomotive locomotive, List<Wagon> wagons) : this()
        {
            Locomotive = locomotive;
            Wagons.AddRange(wagons);
        }

        public Train(Train other) : this(other.Locomotive, other.Wagons) 
        {
        }

        public Locomotive Locomotive { get; set; }
        public List<Wagon> Wagons { get; set; }
    }
}
