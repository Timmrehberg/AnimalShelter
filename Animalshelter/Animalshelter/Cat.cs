using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    public class Cat : Animals
    {
        
      

        public Cat(int Age, double Weight, string Name, string Breed, double Price, bool gotShots,string MaleOrFemale)
        {
            age = Age;
            weight = Weight;
            name = Name;
            breed = Breed;
            price = Price;
            gotshots = gotShots;
            maleorfemale = MaleOrFemale;
            Dailyservings = 1;
            
            if(weight < 10)
            {
                Dailyservings = 1;
            }
            else if (weight > 10)
            {
                Dailyservings += 2;
            }
            else if(weight > 20)
            {
                Dailyservings += 3;
            }
            else if (weight > 30)
            {
                Dailyservings += 4;
            }
        }
        public void Checkcatvaccine()
        {
            if (gotshots == true)
            {
                Console.WriteLine("Your cat is all vaccinated and ready to go your price for this animal is " + price);
            }
                if (gotshots == false)
                {
                    Console.WriteLine("Your cat is not updated with his shots would you like to vaccinate for an additional 45.00- Yes or No");
                    string vaccinateornot = Console.ReadLine();
                    if (vaccinateornot.Equals("Yes"))
                    {
                        Console.WriteLine("Ok price for this animal is " + (price + 45));
                        Console.WriteLine();
                    }
                    else if (vaccinateornot.Equals("No"))
                    {
                        Console.WriteLine("Ok price for this animal is " + price);
                    }
                }
                }
            }
       
        }





    

