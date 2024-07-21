using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    
    public class Category
    {
        List<Destination> destinations = new List<Destination>();

        public string CategoryName { get; set; }


        public Category(string CategoryName)
        {
            this.CategoryName = CategoryName;
        }




    }
}
