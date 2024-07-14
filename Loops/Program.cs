namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //For Each Loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string j in cars)
            {
                Console.WriteLine(j);
            }

            //While Loop
            int k = 0;
            while (k < 5)
            {
                Console.WriteLine(k);
                k++;
            }

            //DoWhile Loop
            int l = 0;
            do
            {
                Console.WriteLine(l);
                l++;
            }
            while (l < 5);
        }
    }
}
