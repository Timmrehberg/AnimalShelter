using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    class Donatedcats 
    {
        
        
        
        public void Newbatchofcats()
        {
            List<Cat> Donatelist = new List<Cat>();
            Cat Louis = new Cat(3, 15, "Louis", "Bengal", 50.00, true, "Male");
            Cat Hector = new Cat(6, 20, "Fatty", "Toyger", 120.00, true, "Female");
            Donatelist.Add(Louis);
            Donatelist.Add(Hector);
            
          
        }
    }
}
