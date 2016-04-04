using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    public class Shelter
    {
        public Cage cages = new Cage();
        Cat Jingles = new Cat(1, 5, "Jingles", "Siamese", 50.00, false,"Male");
        Cat James = new Cat(3, 15, "James", "Bengal", 99.00, true,"Male");
        Cat Fuzzy = new Cat(2, 10, "Fuzzy", "Persian", 30.00, false,"Female");
        Cat Hughey = new Cat(6, 35, "Hughey", "Maine Coon", 65, true,"Male");
        Cat Benjie = new Cat(7, 20, "Benjie", "Sphynx cat", 45.00, true,"Female");

        Dog Leo = new Dog(6, 53, "Leo", "Bulldog", 75, true, "Male");
        Dog Thomas = new Dog(3, 70, "Tommy boy", "German Shepard", 100.00, true, "Female");
        Dog Jake = new Dog(2, 45, "Jake", "Siberian Husky", 95.00, false, "Female");
        Dog Larry = new Dog(7, 22, "Larry", "Beagle", 50.00, true, "Male");
        Dog Ace = new Dog(1, 70, "Ace", "Golden Retriever", 75.00, false, "Female");


        
        public void addcatstocage()
        {
            Console.WriteLine("The cats available for adoption are- ");
            cages.Addcats(Jingles);
            cages.Addcats(James);
            cages.Addcats(Fuzzy);
            cages.Addcats(Hughey);
            cages.Addcats(Benjie);
            Console.WriteLine();
        }
        public void adddogtocage()
        {
            Console.WriteLine("The dogs available for adoption are- ");
            cages.Adddogs(Leo);
            cages.Adddogs(Thomas);
            cages.Adddogs(Jake);
            cages.Adddogs(Larry);
            cages.Adddogs(Ace);

        }
        public void Whatanimals()
        {
            Console.WriteLine("Which type of animal are you looking for Cats or Dogs or Both?");
            string animaltype = Console.ReadLine();
            if (animaltype.Equals("Cats"))
            {
                addcatstocage();
            }
            else if (animaltype.Equals("Dogs"))
            {
                adddogtocage();
            }
            else
            {
                addcatstocage();
                adddogtocage();
            }
        }
       


    }

    }

