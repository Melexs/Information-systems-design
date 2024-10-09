using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моря
{
    public static class SeaItemFactory
    {
        public static SeaItem Create(string input)
        {
            var parts = input.Split(new[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
            var name = parts[0].Trim('\'');
            var properties = parts[1].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            var depth = double.Parse(properties[0].Replace(',', ','));
            var salinity = float.Parse(properties[1].Replace(',', ','));

            if (name.StartsWith("Флора"))
            {
                return new SeaFlora(name, depth, salinity, properties[2], double.Parse(properties[3].Replace(',', ',')));
            }
            else if (name.StartsWith("Фауна"))
            {
                return new SeaFauna(name, depth, salinity, properties[2], int.Parse(properties[3]));
            }
            else
            {
                return new Sea(name, depth, salinity);
            }
        }
    }
}

