using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    internal class FilterDestinations
    {

        public static void find_destination()
        {
            var (categories, destinations) = Category.getData();

            var query = from destination in destinations
                        where destination.Duration!=null && Int32.Parse(destination.Duration)<100
                        select destination;

            Console.WriteLine("Destinations with duration time less than 100 minutes: \n");
            int i = 0;
            foreach (var destination in query) {
                Console.Write($"[{i}] ");
                Console.Write(destination.Name);
                Console.WriteLine($": {destination.Duration} minutes");
                i++;
            }
            
        }
        



    }
}
