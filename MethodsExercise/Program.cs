using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string StoryName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string StoryColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string StoryAnimal = Console.ReadLine();

            Console.WriteLine("Whats your favorite band?");
            string StoryBand = Console.ReadLine();

            Console.WriteLine($"My friend {StoryName} turned {StoryColor}.");
            Console.WriteLine($"He saw the leadsinger from {StoryBand} had the same {StoryAnimal} as him!!!!!!!!");
        }
        public int Sum(int a, int b)
        {
            a = 4;
            b = 2;
            int answer = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {answer}.");
            return answer;
        }

        public int Multiply(int a, int b)
        {
            a = 10;
            b = 2;
            int answer = a * b;
            Console.WriteLine($"The quotient of {a} and {b}is {answer}.");
            return answer;
        }
    }
}
