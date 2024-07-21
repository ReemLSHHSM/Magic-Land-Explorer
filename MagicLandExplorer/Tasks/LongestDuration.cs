using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    internal class LongestDuration
    {
        public static void longest_Duration()
        {
            var (categories, destinations) = Category.getData();

            var query = destinations
                .Where(destination=>destination.Duration!=null)
                .MaxBy(destination=>Int32.Parse(destination.Duration)) ;
            
            Console.WriteLine($"Destination with the longest duration is:\n\n{query.Name} it has duration of: {query.Duration} minutes \n");
        }
    }
}
