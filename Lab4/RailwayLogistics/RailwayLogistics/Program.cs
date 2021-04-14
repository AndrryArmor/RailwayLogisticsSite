using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    class Program
    {
        static void Main(string[] args)
        {
            System system = new System();
            system.Start();
            Administrator administrator = system.Administrator;
            Client client = system.AuthoriseNewClient("Oleksii");

            client.AddDelivery("Пшениця", 150, 180, "Київ", "Вінниця");
            
            var deliveries = new List<Delivery>(administrator.GetDeliveries());
            var delivery = deliveries[0];
            Console.WriteLine("Створено нове замовлення:\n" + 
                "Товар: {0}\n" + 
                "Маса: {1}\n" + 
                "Об'єм: {2}\n" + 
                "Станція відправлення: {3}\n" + 
                "Станція прибуття: {4}", delivery.Good, delivery.Weight, delivery.Volume, delivery.DepartureStation.Name, delivery.ArrivalStation.Name);
            Console.WriteLine();

            var locomotive = delivery.DepartureStation.Locomotives[0];
            if (locomotive < delivery.ArrivalStation.Locomotives[0])
                locomotive = delivery.ArrivalStation.Locomotives[0];
            
            var wagons = delivery.DepartureStation.Wagons;

            administrator.AddTrainToDelivery(delivery, new Train(locomotive, wagons[0] + wagons[2]));

            delivery++;
            delivery++;

            Console.ReadKey();
        }
    }
}
