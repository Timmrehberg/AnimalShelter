using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    public class Cage
    {

        public List<Cat> Catcage = new List<Cat>();
        public List<Dog> Dogcage = new List<Dog>();
        int cagenumber;
        Donatedcats morecats = new Donatedcats();
        Cat Jingles = new Cat(1, 5, "Jingles", "Siamese", 50.00, false, "Male");
        Cat James = new Cat(3, 15, "James", "Bengal", 99.00, true, "Male");
        Cat Fuzzy = new Cat(2, 10, "Fuzzy", "Persian", 30.00, false, "Female");
        Cat Hughey = new Cat(6, 35, "Hughey", "Maine Coon", 65, true, "Male");
        Cat Benjie = new Cat(7, 20, "Benjie", "Sphynx cat", 45.00, true, "Female");

        Dog Leo = new Dog(6, 53, "Leo", "Bulldog", 75, true, "Male");
        Dog Thomas = new Dog(3, 70, "Tommy boy", "German Shepard", 100.00, true, "Female");
        Dog Jake = new Dog(2, 45, "Jake", "Siberian Husky", 95.00, false, "Female");
        Dog Larry = new Dog(7, 22, "Larry", "Beagle", 50.00, true, "Male");
        Dog Ace = new Dog(1, 70, "Ace", "Golden Retriever", 75.00, false, "Female");
        public void addcatstocage()
        {
            Addcats(Jingles);
            Addcats(James);
            Addcats(Fuzzy);
            Addcats(Hughey);
            Addcats(Benjie);
            Console.WriteLine();
        }
        public void adddogtocage()
        {
            Adddogs(Leo);
            Adddogs(Thomas);
            Adddogs(Jake);
            Adddogs(Larry);
            Adddogs(Ace);
        }

        public void Addcats(Cat name)
        {
            Catcage.Add(name);
           

        }
        public void Adddogs(Dog name)
        {
            Dogcage.Add(name);
           
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
        public void Listremainingdogs()
        {
            int cagecount = 1;
            foreach (Dog doggy in Dogcage)
            {
                Console.WriteLine(doggy.name + " Is in cage " + cagecount++ + " age is " + doggy.age + " weight is " + doggy.weight + " breed is " + doggy.breed + " price is " + doggy.price + " is a " + doggy.maleorfemale + " got shots T/F- " + doggy.gotshots);
            }
        }
        public void RemoveCatandcheck()
        {
            Console.WriteLine("Enter cats name");
            string catsname = Console.ReadLine();
            foreach (Cat kitty in Catcage)

            {
                if (catsname.Equals(kitty.name))
                {
                    kitty.Checkcatvaccine();
                    Catcage.Remove(kitty);
                    break;
                }
            }


        }
        public void Whichanimal()
        {
            addcatstocage();
            adddogtocage();
            Console.WriteLine("Which animal are you looking to adopt-Cat or Dog?");
            string typeofanimal = Console.ReadLine();
            if (typeofanimal.Equals("Cat"))
            {
                ListAllcats();
                RemoveCatandcheck();
                adoptmultiple();
            }
            else if (typeofanimal.Equals("Dog"))
            {
                Listremainingdogs();
                RemoveDogandcheck();
                adoptmultiple();
                
                
            }
        }
        public void adoptmultiple()
        {
            Console.WriteLine("Would you like to adopt another animal?-Yes or No");
            string askaboutsecondanimal = Console.ReadLine();
            if (askaboutsecondanimal.Equals("No"))
            {
                Console.WriteLine("Thanks for coming in!");
                Environment.Exit(0);
            }
            else if (askaboutsecondanimal.Equals("Yes"))
            {
                Whichanimaltwo();
            }
        }
        public void RemoveDogandcheck()
        {
            Console.WriteLine("Enter dogs name");
            string dogsname = Console.ReadLine();
            foreach (Dog dogg in Dogcage)

            {
                if (dogsname.Equals(dogg.name))
                {
                    dogg.Checkshots();
                    Dogcage.Remove(dogg);
                    break;
                    
                }
            }
        }
        public void Whichanimaltwo()
        {
            
            Console.WriteLine("Which animal are you looking to adopt-Cat or Dog?");
            string typeofanimal = Console.ReadLine();
            if (typeofanimal.Equals("Cat"))
            {
                ListAllcats();
                RemoveCatandcheck();
                


            }
            else if (typeofanimal.Equals("Dog"))
            {
                Listremainingdogs();
                RemoveDogandcheck();
                

            }
        }
    }
}

            

        

        
        

        
         

        
              

           

        


    

