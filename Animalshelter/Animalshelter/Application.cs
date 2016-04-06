using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter
{
    class Application
    {
        List<string> Wronganswers = new List<string>();
        List<string> Correctanswers = new List<string>();
       public void applicationtest()
        {
            Console.WriteLine("Enter your first name and last name");
            string adoptersname = Console.ReadLine();
            Console.WriteLine("Hello " + adoptersname + " welcome to the human society before we continue we will be asking you a few questions to see if our animals are a good fit for your household please only type the letter ex: A,B,C");
            Console.WriteLine("Question 1:Have you ever or would eber inflict harm upon any species? -A.Yes, B.No");
            string answerone = Console.ReadLine();
            if (answerone.Equals("A"))
            {
                Wronganswers.Add(answerone);
            } else if (answerone.Equals("B"))
            {
                Correctanswers.Add(answerone);
            }
            Console.WriteLine("Question 2:How many children do you have in your house?-A.None,B.One,C.Two,D.3 or more" );
            string answertwo = Console.ReadLine();
            if (answertwo.Equals("A"))
            {
                Correctanswers.Add(answertwo);
            } else if (answertwo.Equals("B"))
            {
                Correctanswers.Add(answertwo);
            } else if (answertwo.Equals("C"))
            {
                Correctanswers.Add(answertwo);
            } else if (answertwo.Equals("D"))
            {
                Wronganswers.Add(answertwo);
            }
            Console.WriteLine("Question 3: Have you ever been convicted of a felony of any kind?-A.Yes,B.No");
            string answerthree = Console.ReadLine();
            if (answerthree.Equals("A"))
            {
                Wronganswers.Add(answerthree);
            } else if (answerthree.Equals("B"))
            {
                Correctanswers.Add(answerthree);
            }
            Console.WriteLine("Question 4: Agree or disagree with this statment 'I think Michael Vick is a good person with a good heart!'-A.Agree,B.Disagree   ");
            string answerfour = Console.ReadLine();
            if (answerfour.Equals("A"))
            {
                Wronganswers.Add(answerfour);
            } else if (answerfour.Equals("B"))
            {
                Correctanswers.Add(answerfour);
            }
            Console.WriteLine("Question 5: Do you have a fenced yard?-A.Yes,B.No");
            string answerfive = Console.ReadLine();
            if (answerfive.Equals("A"))
            {
                Correctanswers.Add(answerfive);
            } else if (answerfive.Equals("B"))
            {
                Wronganswers.Add(answerfive);
            }
            Console.WriteLine("Question 6: How long will your adopted animal be at home alone?-A.More than 8 hours, B.Less than 8 hours,C.Never");
            string answersix = Console.ReadLine();
            if (answersix.Equals("A"))
            {
                Wronganswers.Add(answersix);
            } else if (answersix.Equals("B"))
            {
                Correctanswers.Add(answersix);
            } else if (answersix.Equals("C"))
            {
                Correctanswers.Add(answersix);
            }
            Console.WriteLine("Question 7:What do you plan to do with your animal if you have to move?-A.Bring him with,B.Give him to a family member,C.Put up for adoption");
            string answerseven = Console.ReadLine();
            if (answerseven.Equals("A"))
            {
                Correctanswers.Add(answerseven);
            } else if (answerseven.Equals("B"))
            {
                Correctanswers.Add(answerseven);
            } else if (answerseven.Equals("C"))
            {
                Wronganswers.Add(answerseven);
            }
            Console.WriteLine("Question 8:In the event of a emergency do you have someone who could care for your animal?-A.Yes,B.No,C.Maybe");
            string answereight = Console.ReadLine();
            if (answereight.Equals("A"))
            {
                Correctanswers.Add(answereight);
            } else
            {
                Wronganswers.Add(answereight);
            }
            if (Correctanswers.Count > Wronganswers.Count)
            {
                Console.WriteLine("You will be perfect fit for our furry animals!");
            } else if(Wronganswers.Count >= Correctanswers.Count)
            {
                Console.WriteLine("Sorry just dont think were a good fit for eachother but thanks for coming in!");
                Environment.Exit(0);
            }
            
        }
    }
}
