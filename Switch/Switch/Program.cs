using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Switch Statements");
            Console.WriteLine("Task 1");

            Console.WriteLine("Try and guess my favourite bird - Kiwi / Tui / Sparrow");
            string bird = Console.ReadLine().ToLower();

            switch (bird)
            {
                case "kiwi":
                case "sparrow":
                    Console.WriteLine("Sorry wrong answer");
                    break;

                case "tui":
                    Console.WriteLine("You guessed correctly");
                    break;

                default:
                    Console.WriteLine("Sorry that was not an option");
                    break;                    
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Try and guess my favourite colour - Red / Green / Blue");
            string colour = Console.ReadLine().ToLower();

            switch (colour)
            {
                case "blue":
                case "red":
                    Console.WriteLine("Sorry wrong answer");
                    break;

                case "green":
                    Console.WriteLine("That is correct");
                    break;

                default:
                    Console.WriteLine("Sorry that was not an option");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            
               
            Console.WriteLine("Try and guess my eye colour - Blue / Green / Hazel");
            string eyecolour = Console.ReadLine().ToLower();

            switch (eyecolour)
            {
                case "blue":
                case "green":
                    Console.WriteLine("Sorry thats incorrect");
                    break;

                case "hazel":
                    Console.WriteLine("That is correct");
                    break;

                default:
                    Console.WriteLine("That wasn't an option");
                    break;                
            }
            */

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Task 2");

            Console.WriteLine("Fruit Price Checker - Apples / Oranges / Bananas / Lemons");
            string fruit = Console.ReadLine().ToLower();
            string response;
        
            switch (fruit)
            {
                case "apples":
                    response = ("Apples: $4.99kg");
                    break;

                case "oranges":
                    response = ("Oranges: $3.99kg");
                    break;

                case "bananas":
                    response = ("Bananas: $2.69kg");
                    break;

                case "lemons":
                    response = ("Lemons: $7.99kg");
                    break;

                default:
                    response = ("That was not an option");
                    break;                   
            }

            Console.WriteLine(response);

            Console.ReadLine();


            Console.WriteLine("Vegetable Price Checker - Carrot / Cucumber / Capsicum / Mushroom");
            string vegetable = Console.ReadLine().ToLower();
           
            switch (vegetable)
            {
                case "carrot":
                    Console.WriteLine("Carrot: $1.99kg");
                    break;

                case "cucumber":
                    Console.WriteLine("Cucumber: $1.99ea");
                    break;

                case "capsicum":
                    Console.WriteLine("Capsicum: 3 for $5.00");
                    break;

                case "mushroom":
                    Console.WriteLine("Mushrooms: $10.99kg");
                    break;

                default:
                    Console.WriteLine("That was not an option");
                    break;                                      
                             
            }

            Console.ReadLine();




































        }
    }
}
