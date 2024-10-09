using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Моря
{

    public abstract class SeaItem
    {
        public string Name { get; }
        public double Depth { get; }
        public float Salinity { get; }

        protected SeaItem(string name, double depth, float salinity)
        {
            Name = name;
            Depth = depth;
            Salinity = salinity;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Глубина: {Depth}");
            Console.WriteLine($"Соленость: {Salinity}");
        }
    }
}





