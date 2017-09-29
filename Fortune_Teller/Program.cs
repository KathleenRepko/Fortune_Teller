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
            //Correct GitHub link is properly submitted
            //GitHub repository created from correct folder and contains solution file

            //Ask the user for the user’s first name
            //Ask the user for the user’s last name
            //Ask the user for the user’s age
            //Ask the user for the user’s birth month(as an 'int')
            //Ask the user for the user’s favorite ROYGBIV color
            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            //Ask the user for the number of siblings the user has

            Console.WriteLine("Welcome to Madame Sybil's Fortune Telling Tent. I knew you were coming.");
            Console.WriteLine("What is your first name? Type it, and then click \"Enter.\"");
            string firstName = Console.ReadLine();
            Console.WriteLine("Lovely! Thank you!");
            Console.WriteLine("What is your last name? Type it, and then click \"Enter.\"");
            string lastName = Console.ReadLine();
            Console.WriteLine("I new a " + lastName + " family from Poughkeepsie. Uncanny!");
            Console.WriteLine("How many years have you been alive? Type a number, and then click \"Enter.\"");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge < 30)
            {
                Console.WriteLine("Such a youthful creature!");
            }
            else if (userAge < 65 && userAge >= 30)
            {
                Console.WriteLine("With age comes wisdom!"); 
            }
            else
            {
                Console.WriteLine("I respect my elders!");
            }
            Console.WriteLine("In what month were you born? Please type the number of the month, and then click \"Enter.\"");
            int userMonth = int.Parse(Console.ReadLine());
            if (userMonth == 1 || userMonth == 2 || userMonth == 3 || userMonth == 11 || userMonth == 12)
            {
                Console.WriteLine("Brrr! You were born in a cold month!");
            }
            else if (userMonth == 4 || userMonth == 5 || userMonth == 6)
            {
                Console.WriteLine("Ahhhh, springtime!");
            }
            else if (userMonth == 7 || userMonth == 8)
            {
                Console.WriteLine("Summer baby! Me too!");
            }
            else
            {
                Console.WriteLine("Autumn is such a lovely time of year.");
            }
            Console.WriteLine("What is your favourite ROYGBIV colour? If you do not know what ROYGBIV is, please type \"Help\" and click \"Enter.\"");
            
            string faveColor = Console.ReadLine();
            int sibCount = int.Parse(Console.ReadLine());
            
            
            
            
            
            
          

             
               

        }
    }
}
