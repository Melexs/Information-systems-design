using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Моря
{
    internal class Seas
    {
        static void Main()
        {
            string input = "'Тихий океан': 3970.5:  35.2";
            Item item = Item.Read(input);

            

            Console.WriteLine($"Название: {item.Name}");
            Console.WriteLine($"Глубина: {item.Depth}");
            Console.WriteLine($"Соленость: {item.Salinity}");
            Console.ReadKey();
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Depth { get; set; }
        public float Salinity { get; set; }

        public static Item Read(string input)
        {
            string[] parts = input.Split(new[] { ':' }, 3);


            string name = parts[0];
            double depth =Convert.ToDouble(parts[1], CultureInfo.InvariantCulture);
            float salinity = float.Parse(parts[2], CultureInfo.InvariantCulture);

            return new Item
            {
                Name = name,
                Depth = depth,
                Salinity = salinity
            };
        }
    }

}



