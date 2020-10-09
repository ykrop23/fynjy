using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adress
{

    class Adress
    {
        public Adress(int index, string Ukrain, string Brovary, string street, int house, int apartament)
        {
            this.index = index;
            this.Ukrain = Ukrain;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartament = apartament;
        }

        public int index { get; set; }
        public string Ukrain { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartament { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Index: {index}");

            Console.WriteLine($"Country: {Ukrain}");

            Console.WriteLine($"City: {city}");

            Console.WriteLine($"Street: {street}");

            Console.WriteLine($"House: {house}");

            Console.WriteLine($"Apartament: {apartament}");
        }
    }
}
