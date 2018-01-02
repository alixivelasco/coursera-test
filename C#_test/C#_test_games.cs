using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry, we didn't understand. ";
                message = message + "You Lose.";

            }

            Console.WriteLine(message);
            Console.ReadLine();


            /*alternative game 
             Console.WriteLine("Win the Boat - find the lucky number");
             Console.Write("Choose a door: 1 between 10 : ");
             string userValue = Console.ReadLine();

             string message = (userValue == "5") ? "boat" : "kettle";

             //Console.Write("You won a ");
             //Console.Write(message);
             //Console.Write(".");
             //Console.ReadLine();

             Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);

             Console.ReadLine();
             */
        }
    }
}

