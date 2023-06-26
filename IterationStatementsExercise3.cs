namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Numbers(int num1, int num2)
        {
            for (int i = 1000; i <= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
       

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Triples(int num)
        {
            for (int i = 3; i < -999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void AreTheyEqual(int num1, int num2)
        {
            
            if (num1 == num2)
                Console.WriteLine($"{num1} is equal to {num2}");
            else
                Console.WriteLine($"{num1} is not equal to {num2}");
        }
        
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number)
        {

            if (number % 2 == 0)
            {
               Console.WriteLine($"{number} is even");
            }
            else
                Console.WriteLine($"{number} is odd");
        }
        
        //Write a method to check whether a given number is positive or negative
        public static string PositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else if (number < 0)
                Console.WriteLine($"{number} is negative");
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void AbleToVote()
        {
            Console.WriteLine("Enter your age.");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Able to vote.");
            }
            else
            {
                Console.WriteLine("Not able to vote.");
            }
                
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is in range");
            }
            else
            {
                Console.WriteLine($"{number} is out of range");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static int MultiplicationTable(int number)
        {
           for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {number} = {x * number}");

            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Numbers();
            Triples();
            AreTheyEqual(5,5);
            EvenOrOdd(2);
            AbleToVote();
            InRange();
            MultiplicationTable(12);
        }
    }
}
