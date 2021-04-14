using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Administrator
    {
        public Administrator()
        {
        }

        public Administrator(string name, System system) : this()
        {
            Name = name;
            System = system;
        }

        public Administrator(Administrator other) : this(other.Name, other.System)
        {
        }

        public string Name { get; set; }
        public System System { get; set; }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return System.GetDeliveries();
        }

        public IEnumerable<Station> GetStations()
        {
            return new List<Station>();
        }

        public void AddTrainToDelivery(Delivery delivery, Train train)
        {

        }

        public void MarkAsInProgress(Delivery delivery)
        {

        }
    }
}
