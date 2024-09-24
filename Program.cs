namespace topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            int planet;

            Console.Write("Please enter your current weight on Earth: ");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus       2. Mars        3. Jupiter");
            Console.WriteLine();
            Console.WriteLine("4. Saturn      5. Uranus      6. Neptune");
            Console.WriteLine();
            Console.Write("Which planet are you visiting? ");
            Int32.TryParse(Console.ReadLine(), out planet);
            if (planet == 1)
                Console.WriteLine("Your weight on Venus is " + (weight * 0.78));
            else if (planet == 2)
                Console.WriteLine("Your weight on Mars is " + (weight * 0.39));
            else if (planet == 3)
                Console.WriteLine("Your weight on Jupiter is " + (weight * 2.65));
            else if (planet == 4)
                Console.WriteLine("Your weight on Saturn is " + (weight * 1.17));
            else if (planet == 5)
                Console.WriteLine("Your weight on Uranus is " + (weight * 1.05));
            else if (planet == 6)
                Console.WriteLine("Your weight on Neptune is " + (weight * 1.23));
            else
                Console.WriteLine("That's not a planet, silly!");
        }
    }
}
