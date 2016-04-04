using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    public class Dog : Animals
    {
        public List<Dog> dogs = new List<Dog>();
    
        public Dog(int Age, double Weight, string Name, string Breed, double Price, bool gotShots,string MaleOrFemale)
        {
            age = Age;
            weight = Weight;
            name = Name;
            breed = Breed;
            price = Price;
            gotshots = gotShots;
            maleorfemale = MaleOrFemale;
                 
            
            
        }
    }
}
