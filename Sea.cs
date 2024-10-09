using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моря
{
    public class Sea : SeaItem
    {
        public Sea(string name, double depth, float salinity)
            : base(name, depth, salinity)
        {
        }
    }
}
