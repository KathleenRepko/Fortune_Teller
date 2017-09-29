using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        private static string faveColor2;

        static void Main(string[] args)
        {
            //Correct GitHub link is properly submitted
            //GitHub repository created from correct folder and contains solution file

            //Declaring variables and asking for user input:

            Console.WriteLine("Welcome to Madame Sybil's Fortune Telling Tent. I knew you were coming.");
            Console.WriteLine("\nWhat is your first name? Type it, and then click \"Enter.\"");
            string firstName = Console.ReadLine();
            Console.WriteLine("\nLovely! Thank you!");

            Console.WriteLine("\nWhat is your last name? Type it, and then click \"Enter.\"");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nI new a " + lastName + " family from Poughkeepsie. Uncanny!");

            Console.WriteLine("\nHow many years have you been alive? Type a number, and then click \"Enter.\"");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge < 30)
            {
                Console.WriteLine("\nSuch a youthful creature!");
            }
            else if (userAge < 65 && userAge >= 30)
            {
                Console.WriteLine("\nWith age comes wisdom!");
            }
            else
            {
                Console.WriteLine("\nI respect my elders!");
            }
            Console.WriteLine("\nIn what month were you born? Please type the number of the month, and then click \"Enter.\"\nIf you enter a word, I will cry and go home.");
            int userMonth = int.Parse(Console.ReadLine());
            if (userMonth == 1 || userMonth == 2 || userMonth == 3 || userMonth == 11 || userMonth == 12)
            {
                Console.WriteLine("\nBrrr! You were born in a cold month!");
            }
            else if (userMonth == 4 || userMonth == 5 || userMonth == 6)
            {
                Console.WriteLine("\nAhhhh, springtime!");
            }
            else if (userMonth == 7 || userMonth == 8)
            {
                Console.WriteLine("\nSummer baby! Me too!");
            }
            else 
            {
                Console.WriteLine("\nAutumn is such a lovely time of year.");
            }
            
            Console.WriteLine("What is your favorite ROYGBIV color?\nIf you do not know what ROYGBIV is, please type \"Help\" and click \"Enter.\"");
            string faveColor = Console.ReadLine().ToLower();


            switch (faveColor)
            {
                case "help":
                    Console.WriteLine("ROYGBIV is an acronym for the colors red, orange, yellow, green, blue, indigo, and violet.\nThink RAINBOW!");
                    //How does the user return to the color question?
                    break;
                case "red":
                    Console.WriteLine("\nRuby red!");
                    break;
                case "orange":
                    Console.WriteLine("\nOrange you glad you came in today?");
                    break;
                case "yellow":
                    Console.WriteLine("\nLike Yellowstone - beautiful!");
                    break;
                case "green":
                    Console.WriteLine("\nGreen is my favorite color as well!");
                    break;
                case "blue":
                    Console.WriteLine("\nBlue, like the skies over Keuka Lake!");
                    break;
                case "indigo":
                    Console.WriteLine("\nI'm pretty sure indigo is a made up color, but OK.");
                    break;
                case "violet":
                    Console.WriteLine("\nPurple - very regal!");
                    break;
                default:
                    Console.WriteLine("\nYou do not know ROYGBIV? Your future looks bleak.");
                    break;
            }

            Console.WriteLine("\nHow many siblings do you have? Enter a number, and then click \"Enter.\"");
            int sibCount = int.Parse(Console.ReadLine());
            
            if(sibCount == 0)
            {
                Console.WriteLine("\nAn only child!");
            }
            else if(sibCount > 0 && sibCount <4)
            {
                Console.WriteLine("\nSounds like a cozy family.");
            }
            else if(sibCount < 0)
            {
                Console.WriteLine("\nBy entering a negative number, do you mean that your parents sold your siblings to the gypsies? Perhaps I know your family!");
            }
            else
            {
                Console.WriteLine("\nWow! What size wagon did your family need to get around?");
            }

            //Conditionals:

            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
            string retireAge;
            if (userAge % 2 == 0)
            {
                retireAge = "even";
            }
            else
            {
                retireAge = "odd";
            }
            //If the user’s number of siblings is 0, then they will have a vacation home in ____(location),
            string vacaHome;
            if(sibCount == 0)
            {
                vacaHome = "New York City";
            } 
            //or 1 then they will have a vacation home in ____(location),
            else if(sibCount == 1)
            {
                vacaHome = "Chicago";
            }
            //or 2 then they will have a vacation home in ____(location), 
            else if(sibCount == 2)
            {
                vacaHome = "Omaha";
            }
            //or 3 then they will have a vacation home in ____(location), 
            else if(sibCount == 3)
            {
                vacaHome = "Key West";
            }
            //or more than 3 then they will have a vacation home in ____(location).
            else if(sibCount > 3)
            {
                vacaHome = "Sedona";
            }
            //If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
            else
            {
                vacaHome = "Siberia";
            }

            //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation(i.e.car, boat, plane, etc.)
            string modeTransportation;
            switch faveColor
                {
                case red:
                    modeTransportation = "sportscar";
                    break;
                case orange:
                    modeTransportation = "scooter";S

            }
                

            //If the user’s birth month is 1 - 4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9-12, then they will have $____ in the bank. 
            //If the user enters something other than 1-12 as their birth month, they will have $0.00 in the bank.

            //The user’s fortune should be written as such:
            //[First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.


            Console.WriteLine("\nI look in the crystal ball, and Spirit is telling me this:");
            Console.WriteLine(firstName + " " + lastName " will retire in " + )










        }

    }
}



    





             
               

        
    

