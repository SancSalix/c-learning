using System;

namespace InputAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            int excitement = 0;
             

            Console.WriteLine("Hi! We are starting out on a great journey");
            Console.WriteLine("You and I");
            Console.WriteLine("Are you excited?");
            Console.WriteLine("Type 1 for yes, 2 for no, and 3 for eh: ");

            excitement = Convert.ToInt32(Console.ReadLine());

            switch (excitement)
            {
                case 1:
                    Console.WriteLine("Me too! : D");
                    break;
                case 2:
                    Console.WriteLine("Well once we get to know eachother, maybe that will change");
                    break;
                case 3:
                    Console.WriteLine("Perk up!");
                    break;
                default:
                    Console.WriteLine("You don't follow instructions very well");
                    break;
            }

        }
    }
}
