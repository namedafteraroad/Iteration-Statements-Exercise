using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000


        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        //set to divide, if there is a remaineder then
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            //PrintN100021000();
            //ByThrees2999();
            Int2EqualCheck(5, 5);
            EvenOrOdd(674);
            PositiveOrNegative(0);
            CanVote();
            NumberRangeCheck();
            MultiTable(5);

        }

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintN100021000()
        {
            for (int i = -1000; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
       // Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThrees2999()
        {
            for (int i = 0; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Int2EqualCheck(int x, int y)
        {
            
                if (x == y)
                {
                    Console.WriteLine("is equal"); 
                }
                else 
                {
                    Console.WriteLine("not equal");
                 
                }
            
        }
        //Write a method to check whether a given number is even or odd
        //set to divide, if there is a remaineder then, or mod
        public static void EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }


        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("just zero");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanVote()
        {
            //parsing, we get user input
            Console.WriteLine("Please enter voting age");
            int age = int.Parse(Console.ReadLine());


            if (age >= 18)
            {
                Console.WriteLine("can vote");
            }
            else
            {
                Console.WriteLine("can not vote");
            }
        }








        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10


        //number in range********
        public static void NumberRangeCheck()
        {
            Console.WriteLine("please enter number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("Number in range");
            }
            else { Console.WriteLine("out of range"); }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i*num}");
            }
        }
    }
}
