using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Madame Zeroni's Fortune Telling Tent. I knew you were coming.");
           
            //Declaring variables and asking for user input:

            Console.WriteLine("\nMy friend, what is your first name? Type it, and then click \"Enter.\"");
            string firstName = Console.ReadLine();
            Console.WriteLine("Lovely! Thank you!");
           
            Console.WriteLine("\nWhat is your last name? Type it, and then click \"Enter.\"");
            string lastName = Console.ReadLine();
            Console.WriteLine("I knew a family named " + lastName + " from Poughkeepsie. Uncanny!");

            Console.WriteLine("\nHow many years have you been alive? Type a number, and then click \"Enter.\"");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge < 18)
            {
                Console.WriteLine("You're just a baby!");
            }
            else if (userAge >= 18 && userAge <=40)
            {
                Console.WriteLine("Oh, to be young again...");
            }
            else if (userAge > 40 && userAge < 65)
            {
                Console.WriteLine("With age comes wisdom!");
            }
            else
            {
                Console.WriteLine("I respect my elders!");
            }
            Console.WriteLine("\nIn what month were you born? Please type the number of the month, and then click \"Enter.\"\nIf you enter a word, I may cry and close up shop for the day.");
            int userMonth = int.Parse(Console.ReadLine());
            if (userMonth == 1 || userMonth == 2 || userMonth == 12)
            {
                Console.WriteLine("Brrr! You were born in a cold month!");
            }
            else if (userMonth == 3 || userMonth == 4 || userMonth == 5)
            {
                Console.WriteLine("Ahhhh, springtime!");
            }
            else if (userMonth == 6 || userMonth == 7 || userMonth == 8)
            {
                Console.WriteLine("Summer baby! Me too!");
            }
            else if (userMonth == 9 || userMonth == 10 || userMonth == 11)
            {
                Console.WriteLine("Autumn is such a lovely time of year.");
            }
            else 
            {
                Console.WriteLine("How are the months numbered where you live? That month doesn't exist where I come from. Moving right along...");
            }

            Console.WriteLine("\nWhat is your favorite ROYGBIV color?\nIf you do not know what ROYGBIV is, please type \"Help\" and click \"Enter.\"");
            string faveColor = Console.ReadLine().ToLower();

            switch (faveColor)
            {
                case "help":
                    Console.WriteLine("ROYGBIV is an acronym for the colors red, orange, yellow, green, blue, indigo, and violet.Think RAINBOW!\nI'm sorry that you are unacquainted with ROYGBIV.");
                    break;
                case "red":
                    Console.WriteLine("Red, like my ruby birthstone!");
                    break;
                case "orange":
                    Console.WriteLine("Orange you glad you came in today?");
                    break;
                case "yellow":
                    Console.WriteLine("Like Yellowstone - beautiful!");
                    break;
                case "green":
                    Console.WriteLine("Green is my favorite color as well!");
                    break;
                case "blue":
                    Console.WriteLine("Blue, like the skies over Keuka Lake!");
                    break;
                case "indigo":
                    Console.WriteLine("I'm pretty sure indigo is a made-up color, but OK.");
                    break;
                case "violet":
                    Console.WriteLine("Violet - very regal!");
                    break;
                default:
                    Console.WriteLine("What? You do not know ROYGBIV? Your future looks bleak.");
                    break;
            }

            Console.WriteLine("\nHow many siblings do you have? Enter a number, and then click \"Enter.\"");
            int sibCount = int.Parse(Console.ReadLine());
            
            if(sibCount == 0)
            {
                Console.WriteLine("An only child!");
            }
            else if(sibCount > 0 && sibCount <4)
            {
                Console.WriteLine("Sounds like a cozy family.");
            }
            else if (sibCount >= 4)
            {
                Console.WriteLine("Wow! What size wagon did your family need to get around?");
            }

            else
            {
                Console.WriteLine("By entering a negative number, do you mean that your parents sold your siblings to the gypsies? Perhaps I know your family!");
            }
            
            //Conditionals:

            //User will retire in certain number of years, based on if age is odd or even.
            int retireAge;
            if (userAge % 2 == 0)
            {
                retireAge = 10;
            }
            else
            {
                retireAge = 7;
            }

            //Vacation home is based on number of siblings user entered.
            string vacaHome;
            if(sibCount == 0)
            {
                vacaHome = "New York City";
            } 
            else if(sibCount == 1)
            {
                vacaHome = "Chicago";
            }
            else if(sibCount == 2)
            {
                vacaHome = "Omaha";
            }
            else if(sibCount == 3)
            {
                vacaHome = "Key West";
            }
            else if(sibCount > 3)
            {
                vacaHome = "Sedona";
            }
            //If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
            else
            {
                vacaHome = "Siberia";
            }

            //Mode of transportation is determined by user's favorite color.
            string modeTransportation;
            switch (faveColor)
            {
                case "red":
                    modeTransportation = "little red Corvette";
                    break;
                case "orange":
                    modeTransportation = "scooter";
                    break;
                case "yellow":
                    modeTransportation = "hoverboard";
                    break;
                case "green":
                    modeTransportation = "Jaguar in British Racing Green";
                    break;
                case "blue":
                    modeTransportation = "hot air balloon";
                    break;
                case "indigo":
                    modeTransportation = "VW bus";
                    break;
                case "violet":
                    modeTransportation = "Prius";
                    break;
                default:
                    modeTransportation = "Ford Pinto";
                    break;
            }

            //User's retirement funds are determined by user's birth month.
            int cashBank;
            if (userMonth >= 1 && userMonth <= 4)
            {
                cashBank = 250000;
            }
            else if (userMonth >=5 && userMonth <= 8)
            {
                cashBank = 500000;
            }
            else if (userMonth >= 9 && userMonth <= 12)
            {
                cashBank = 750000;
            }
            else
            {
                cashBank = 0;
            }

            // The fortune will incorporate the variables and conditionals in a final statement.
            Console.WriteLine("\n\nI will now look into my crystal ball and see what your future holds...");
            Console.WriteLine("\n     ...\n          ...\n               ...\n                    ...\n                         ...\n\n");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireAge + " years, with $" + cashBank + " in the bank, a vacation home in " + vacaHome + ", and a " + modeTransportation + " with which to get around.");
            Console.WriteLine("\nMadame Zeroni has spoken. Have a wonderful life!\nAnd don't hit your head on the tent flap on your way out.\n\n");

            










        }

    }
}



    





             
               

        
    

