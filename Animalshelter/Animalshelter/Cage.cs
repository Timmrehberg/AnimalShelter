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
        public void Addcats(Cat name)
        {
            Catcage.Add(name);
            Console.WriteLine(name.name + " Is in cage " + Catcage.Count + " his age is " + name.age + " his weight is " + name.weight + " his breed is " + name.breed + " his price is " + name.price + " he is a " + name.maleorfemale + " and he got his shots T/F- " + name.gotshots);

        }
        public void Adddogs(Dog name)
        {
            Dogcage.Add(name);
            Console.WriteLine(name.name + " Is added to cage " + Dogcage.Count + " his age is " + name.age + " his weight is " + name.weight + " his breed is " + name.breed + " his price is " + name.price + " he is a " + name.maleorfemale + " and he got his shots T/F- " + name.gotshots);
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
                   
                    break;
                }
            }
        }
                public void ListAllcats()
        {
            cagenumber = 1;
         foreach (Cat cats in Catcage)
            {
              Console.WriteLine(cats.name + " Is in cage " + cagenumber++ + " his age is " + cats.age + " his weight is " + cats.weight + " his breed is " + cats.breed + " his price is " + cats.price + " he is a " + cats.maleorfemale + " and he got his shots T/F- " + cats.gotshots);
            }
         

        }
              

            }

        }

        


    

