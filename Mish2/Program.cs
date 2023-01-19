using System; //same as import

namespace Mish2 //project
{
    class Program //container
    {
        static void Main(string[] args)
        {
            int rollCt = 0;

            Console.WriteLine("Welcome to the dice game!\n\n");
            Console.WriteLine("How many times do you want to roll? ");
            rollCt = int.Parse(Console.ReadLine());

            //create random variable
            Random r = new Random();
            Random r2 = new Random();

            //array of 6 spaces
            int[] blah = new int[11];

            //roll 2 die as many times as they want
            for (int i = 0; i < rollCt; i++)
            {
                int roll2 = r2.Next(1,7);

                int roll1 = r.Next(1,7);

                int combo = roll1 + roll2;
                blah[combo - 2]++;
                //Console.WriteLine(roll1);
                //Console.WriteLine(roll2);
            }

            //
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCt + ".\n");

            for (int i = 0; i < 11; i++)
            {
                string stars = "";
                decimal value = Decimal.Divide(blah[i], rollCt);
                decimal news = decimal.Truncate(value * 100);
                //Console.WriteLine("Result: " + "{0}",news);
                for (int c = 0; c < news; c++)
                {
                    stars += "*";
                }
                //Console.WriteLine(Convert.ToInt32(4.0 / 12.0 * 100));
                Console.WriteLine(Convert.ToString(i + 2) + ": " + stars);
            }

            Console.WriteLine("\nThank you for playing the dice game!!");
        }
    }
}
