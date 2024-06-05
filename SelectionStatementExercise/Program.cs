using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        public static void FavoriteNumber() 
        {

            int favNumber = 7;
            Console.WriteLine("What is my favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < 7)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > 7)
            {
                Console.WriteLine("too high");
            }
            else if (userInput == 7) 
            {
                Console.WriteLine("You guessed it!!!");
            }

        }

        public static void FavoriteSubject() 
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Mathematics":
                    Console.WriteLine("Wonderful!  Let's return to the number guessing game!");
                    break;
                case "English":
                    Console.WriteLine("Excellent, we have many letters from Karens you must respond to");
                    break;
                case "Science":
                    Console.WriteLine("Perfect!  Screwtape, send them to test the lava");
                    break;
                case "Phylosophy":
                    Console.WriteLine("Great!  We will promote  you to Imp!");
                    break;
                case "P.E.": 
                    Console.WriteLine("Splendid!  Wormword, send them to the doughnut feeder we used on Home Simpson");
                    break;
                default:
                    Console.WriteLine("Ah!  Well, we will have to start with some general stuff.  PREPARE THE RACK!");
                    break;

            
            }  
            
           
        }    
        static void Main(string[] args)
        {
           
            FavoriteNumber();
            FavoriteSubject();
           

        }
    }
}
