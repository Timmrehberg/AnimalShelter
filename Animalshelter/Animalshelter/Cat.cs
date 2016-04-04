using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    public class Cat : Animals
    {
       public List<Cat> Allcats = new List<Cat>();

        public Cat(int Age, double Weight, string Name, string Breed, double Price, bool gotShots,string MaleOrFemale)
        {
            age = Age;
            weight = Weight;
            name = Name;
            breed = Breed;
            price = Price;
            gotshots = gotShots;
            maleorfemale = MaleOrFemale;
        }
        public void Checkcatvaccine()
        {
            if (gotshots == false)
            {
                Console.WriteLine("Your animal is not updated with his shots would you like to vaccinate for an additional 45.00- Yes or No");
                string vaccinateornot = Console.ReadLine();
                if (vaccinateornot.Equals("Yes"))
                {
                    Console.WriteLine("Ok final price is " + (price + 45));
                    Console.WriteLine();
                }
                else if (vaccinateornot.Equals("No"))
                {
                    Console.WriteLine("Ok final price is " + price);
                }
                else if(gotshots == true)
                {
                    Console.WriteLine("Your animal is all vaccinated and ready to go your final price is " + price);
                    string takehomeanimal = Console.ReadLine();
                }
                }
            }
       
        }





    }

