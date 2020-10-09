using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_1
{
    class Program
    {
        static void Main()
        {
            Address address = new Address();

            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Khreshchatyk Street";
            address.House = "15-б";
            address.Apartament = "68";
            address.Index = "04495";

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartament);
            Console.WriteLine(address.Index);

            Console.ReadKey();
        }
    }
}
