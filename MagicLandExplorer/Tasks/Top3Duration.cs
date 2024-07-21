using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    internal class Top3Duration
    {

        public static void getTop3()
        {
            var (categories, destinations) = Category.getData();

            var query = (from destination in destinations
                         where(destination.Duration!=null)
                         orderby (Int32.Parse(destination.Duration)) descending 
                         select destination).Take(3);

            int i = 0;
            Console.WriteLine("Top 3 longest destinations durations: \n");
            foreach (var duration in query)
            {

               
                Console.WriteLine($"[{i}] {duration.Name} {duration.Duration} minutes");

                i++;



            }
        }
    }
}