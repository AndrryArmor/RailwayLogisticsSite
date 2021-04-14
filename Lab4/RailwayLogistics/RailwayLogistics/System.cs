using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class System
    { 
        private List<Delivery> _deliveries;
        private List<Station> _stations;

        public System()
        {
            IsStarted = false;
            _deliveries = new List<Delivery>();
            _stations = new List<Station>
            {
                new Station("Київ",
                    new List<Wagon>
                    {
                        new Wagon(34, 80, 120),
                        new Wagon(28, 60, 76),
                        new Wagon(44, 70, 150)
                    },
                    new List<Locomotive>
                    {
                        new Locomotive(45, 240)
                    }),
                new Station("Вінниця",
                    new List<Wagon>
                    {
                        new Wagon(34, 80, 120),
                        new Wagon(28, 60, 76),
                        new Wagon(44, 70, 150)
                    },
                    new List<Locomotive>
                    {
                        new Locomotive(40, 200)
                    }),
                new Station("Харків",
                    new List<Wagon>
                    {
                        new Wagon(34, 80, 120),
                        new Wagon(28, 60, 76),
                        new Wagon(44, 70, 150)
                    },
                    new List<Locomotive>
                    {
                        new Locomotive(37, 190)
                    })
            };
        }

        public System(IEnumerable<Delivery> deliveries) : this()
        {
            _deliveries.AddRange(deliveries);
        }

        public System(System other) : this(other.Deliveries)
        {
        }

        public bool IsStarted { get; private set; }
        public Administrator Administrator { get; private set; }
        public ReadOnlyCollection<Station> Stations => _stations.AsReadOnly();
        public ReadOnlyCollection<Delivery> Deliveries => _deliveries.AsReadOnly();

        public void Start()
        {
            Administrator = new Administrator("Admin", this);
            IsStarted = true;
        }

        public Client AuthoriseNewClient(string name)
        {
            return new Client(name, this);
        }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return _deliveries;
        }

        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }

        public int CalculateRouteLength(Station departureStation, Station arrivalStation)
        {
            return 0;
        }

        public Train CreateTrain(Locomotive locomotive, IEnumerable<Wagon> wagons)
        {
            return new Train();
        }

        public IEnumerable<Station> GetStations()
        {
            return new List<Station>();
        }
    }
}
