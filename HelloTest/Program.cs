using System;

namespace HelloTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int randNum = randomNumber.Next(1, 101);
            Console.WriteLine("Please pick a number between 1 and 100");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your choice was " + userChoice);
            numberPicker(userChoice, randNum);

        }

        public static void numberPicker(int a, int rand)
        {
            if (a == rand)
            {
                Console.WriteLine("You picked it! The number was " + rand);
                Console.ReadLine();
            }
            else
            {
                if (a < rand)
                {
                    Console.WriteLine("Incorrect, guess higher!");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    numberPicker(userChoice, rand);
                }
                else if (a > rand)
                {
                    Console.WriteLine("Incorrect, guess lower!");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    numberPicker(userChoice, rand);
                }
            }
            
        }
    }
}
