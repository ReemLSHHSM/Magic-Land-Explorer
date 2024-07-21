using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    internal class SortByName
    {
        public static void sortNames()
        {
            var (categories, destinations) = Category.getData();

            var query = from destination in destinations
                        orderby destination.Name
                        select destination;

            int i = 0;
            Console.WriteLine("Destinations ordered alphabetically : \n");
            foreach (var name in query)
            {
               
                Console.WriteLine($"[{i}] {name.Name} \n");
                i++;
            }
        }
    }
}
