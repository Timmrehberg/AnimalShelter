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
            Dailyservings = 1;
            if (weight < 10)
            {
                Dailyservings = 2;
            }
            else if (weight > 30)
            {
                Dailyservings += 2;
            }
            else if (weight > 60)
            {
                Dailyservings += 3;
            }
            else if (weight > 70)
            {
                Dailyservings += 4;
            }
        }



    
        public void Checkshots()
        {
            if (gotshots == true)
            {
                Console.WriteLine("Your animal " + name + " is ready to go home! Final price is " + price);
            }else if (gotshots == false)
            {
                Console.WriteLine("Your animal is not updated with his shots would you like to get them here for an additional 45-Yes or No");
                string vaccinedog = Console.ReadLine();
                if (vaccinedog.Equals("Yes"))
                {
                    Console.WriteLine("Ok your final price now is " + (price + 45));
                } else
                {
                    Console.WriteLine("Ok your final price is " + price);
                }
            }
        }
    }
}
