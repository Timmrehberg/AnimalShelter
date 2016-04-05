using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    public class Cage
    {
        string adoptcat;

        public List<Cat> Catcage = new List<Cat>();
        public List<Dog> Dogcage = new List<Dog>();
        int cagenumber;
        Donatedcats morecats = new Donatedcats();
        public void Addcats(Cat name)
        {
            Catcage.Add(name);
            Console.WriteLine(name.name + " Is in cage " + Catcage.Count + " age is " + name.age + " weight is " + name.weight + " breed is " + name.breed + " price is " + name.price + " is a " + name.maleorfemale + " and got shots T/F- " + name.gotshots);

        }
        public void Adddogs(Dog name)
        {
            Dogcage.Add(name);
            Console.WriteLine(name.name + " Is added to cage " + Dogcage.Count + "  age is " + name.age + "  weight is " + name.weight + "  breed is " + name.breed + " price is " + name.price + " is a " + name.maleorfemale + " and got shots T/F- " + name.gotshots);
        }

        public void Adoptcat()
        {
            Console.WriteLine("Which cat would you like to adopt?");
            adoptcat = Console.ReadLine();
            foreach (Cat cat in Catcage)
            {

                if (adoptcat.Equals(cat.name))
                {
                    cat.Checkcatvaccine();
                    Catcage.Remove(cat);
                    Console.WriteLine("Would you like to adopt another animal?-Yes or No");
                    string adoptmore = Console.ReadLine();
                    if (adoptmore.Equals("Yes"))
                    {
                        Addmorecats();
                        ListAllcats();                        
                        Adoptcat();

                    }
                    else if (adoptmore.Equals("No"))
                    {
                        Console.WriteLine("Ok thanks");
                    }

                    break;

                }
            }
        }
        public void ListAllcats()
        {
            cagenumber = 1;
            foreach (Cat cats in Catcage)
            {
                Console.WriteLine(cats.name + " Is in cage " + cagenumber++ + " age is " + cats.age + " weight is " + cats.weight + " breed is " + cats.breed + " price is " + cats.price + " is a " + cats.maleorfemale + " got shots T/F- " + cats.gotshots);
               
            }
        }
        public void Addmorecats()
        {
            Console.WriteLine("More cats have been donated!");
            Cat Louis = new Cat(3, 15, "Louis", "Bengal", 50.00, true, "Male");
            Cat Hector = new Cat(6, 20, "Fatty", "Toyger", 120.00, true, "Female");
            Catcage.Add(Louis);
            Catcage.Add(Hector);
        }
        public void Adoptdog()
        {
            Console.WriteLine("What dog would you like to adopt?");
            string adoptdog = Console.ReadLine();
            foreach(Dog dogs in Dogcage)
            if (adoptdog.Equals(dogs.name))
            {
                    dogs.Checkshots();
                    Dogcage.Remove(dogs);
                    Console.WriteLine("Would you like to adopt another dog?-Yes or No");
                    string adoptanotherdog = Console.ReadLine();
                    if (adoptanotherdog.Equals("Yes"))
                    {
                        Listremainingdogs();
                        Adoptdog();
                    }else if (adoptanotherdog.Equals("No"))
                    {
                        Console.WriteLine("Thanks for coming in!");
                        
                    }
                    break;
                }
        }
        public void Listremainingdogs()
        {
            int cagecount = 1;
            foreach(Dog doggy in Dogcage)
            {
                Console.WriteLine(doggy.name + " Is in cage " + cagecount++ + " age is " + doggy.age + " weight is " + doggy.weight + " breed is " + doggy.breed + " price is " + doggy.price + " is a " + doggy.maleorfemale + " got shots T/F- " + doggy.gotshots);
            }
        }

    }
    }

        

        
        

        
         

        
              

           

        


    

