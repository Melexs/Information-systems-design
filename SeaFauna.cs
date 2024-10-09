using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моря
{
    public class SeaFauna : SeaItem
    {
        private string _animalType;
        private int _populationCount;

        public SeaFauna(string name, double depth, float salinity, string animalType, int populationCount)
            : base(name, depth, salinity)
        {
            _animalType = animalType;
            _populationCount = populationCount;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Тип животного: {_animalType}");
            Console.WriteLine($"Численность популяции: {_populationCount}");
        }
    }
}


