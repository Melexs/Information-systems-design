using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Моря.SeaItem;


namespace Моря
{
    internal class Seas
    {
        public static void Main()
        {
            var inputs = new List<string>
            {
                "'Тихий океан': 390,5: 35,2",
                "'Флора Красные водоросли': 50,3: 30,5: Ламинария: 1000",
                "'Фауна Морские звезды': 20,6: 35,2: Asteroidea: 500"
            };

            var seaItems = new List<SeaItem>();
            foreach (var input in inputs)
            {
                var seaItem = SeaItemFactory.Create(input);
                seaItems.Add(seaItem);
            }

            foreach (var seaItem in seaItems)
            {
                seaItem.PrintDetails();
            }

            Console.ReadKey();
        }
    }
}

