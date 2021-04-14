using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Locomotive
    {
        public Locomotive()
        {
        }

        public Locomotive(int weight, int maximumWeight) : this()
        {
            Weight = weight;
            MaximumWeight = maximumWeight;
        }

        public Locomotive(Locomotive other) : this(other.Weight, other.MaximumWeight)
        {
        }

        public int Weight { get; set; }
        public int MaximumWeight { get; set; }


        public static bool operator <(Locomotive locomotiveLeft, Locomotive locomotiveRight)
        {
            Console.WriteLine("Лівий локомотив має вантажопідйомність {0} т, а правий - {1} т.", locomotiveLeft.MaximumWeight, locomotiveRight.MaximumWeight);
            Console.WriteLine("Лівий локомотив має меншу вантажопідйомність? - {0}", locomotiveLeft.MaximumWeight < locomotiveRight.MaximumWeight);
            return locomotiveLeft.MaximumWeight < locomotiveRight.MaximumWeight;
        }

        public static bool operator >(Locomotive locomotiveLeft, Locomotive locomotiveRight)
        {
            Console.WriteLine("Лівий локомотив має вантажопідйомність {0} т, а правий - {1} т.", locomotiveLeft.MaximumWeight, locomotiveRight.MaximumWeight);
            Console.WriteLine("Лівий локомотив має більшу вантажопідйомність? - {0}", !(locomotiveLeft < locomotiveRight));
            return !(locomotiveLeft < locomotiveRight);
        }
    }
}
