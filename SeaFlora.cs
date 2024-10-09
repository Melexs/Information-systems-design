using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моря
{
    public class SeaFlora : SeaItem
    {
        private string _plantType;
        private double _biomassDensity;

        public SeaFlora(string name, double depth, float salinity, string plantType, double biomassDensity)
            : base(name, depth, salinity)
        {
            _plantType = plantType;
            _biomassDensity = biomassDensity;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Тип растения: {_plantType}");
            Console.WriteLine($"Плотность биомассы: {_biomassDensity}");
        }
    }
}