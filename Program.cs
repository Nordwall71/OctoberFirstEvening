using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace OctoberFirstEvening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");

            var userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}, how old are you");

            var userAge = int.Parse(Console.ReadLine());

            if (userAge < 18)
            {
                Console.WriteLine($"You are {userAge}, so you may not vote.");
            }

            else
            {
                Console.WriteLine("You are old enough to vote.  Good luck!");
            }

            Console.WriteLine("Is it sunny or cloudy today?");

            var theWeather = Console.ReadLine();

            if (theWeather.ToLower() == "sunny")

            {
                Console.WriteLine("Awesome!");
            }

            else

            {
                Console.WriteLine("Oh, that'a bummer!");
            }

           

            int theNumber = 4;
            int theAnswer;

            do

            {

                Console.WriteLine("Pick a number between 1 and 10");
                theAnswer = int.Parse(Console.ReadLine());

                if (theAnswer > theNumber)
                {
                    Console.WriteLine($"Nope,{theAnswer} is not correct. Go lower. ");
                }

                else if (theAnswer < theNumber)
                {
                    Console.WriteLine($"{theAnswer} is incorrect, go higher.");
                }

                else if (theAnswer == theNumber)
                {
                    Console.WriteLine("There ya go!");
                }

            }

            while (theAnswer != theNumber);

            Console.WriteLine("Now, what color are your eyes?");
            string eyeColor = Console.ReadLine();

            if (eyeColor.ToLower() == "blue")
            {
                Console.WriteLine("Your eyes are the same as mine!");
            }

            else if (eyeColor != "blue")
            {
                Console.WriteLine("Ah, too bad..."); 
            }

            int thisNumber = 76;
            int thisAnswer;

            do
            {
                Console.WriteLine("Now, let's try a number between 1 and 100");
                thisAnswer = int.Parse(Console.ReadLine());

                if (thisAnswer > thisNumber)
                {
                    Console.WriteLine("That is a bit too high, try again.");
                }

                else if (thisAnswer < thisNumber)
                {
                    Console.WriteLine($"{thisAnswer} is too low, try again...");
                }

                else if (thisAnswer == thisNumber)
                {
                    Console.WriteLine("Now we're getting somewhere!");
                }

            }

            while (thisAnswer != thisNumber);





            
            
                Console.WriteLine("What's your favorite car make?");
                string userCar = Console.ReadLine();
            string retry = "no";
            do
            {
                switch (userCar.ToLower())
                {
                    case "ford":
                        Console.WriteLine("Found On Road Dead!");
                        break;
                    case "chevy":
                        Console.WriteLine("Oh boy...");
                        break;
                    case "toyota":
                        Console.WriteLine("You're smarter than you look!");
                        break;
                    default:
                        Console.WriteLine("Meh...");
                        break;
                }
            }while(retry != "no");
            
            
            
                   


            

              


                    
                    
                    

               
            

        }

        


            




         
    }
}