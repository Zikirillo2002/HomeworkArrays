namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;
            int indexmins = 0;
            int mins = 10;
            bool isnumber;

            Console.Write("Enter the arry length n = ");
            isnumber = int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine();

            while (!isnumber || n <= 0)
            {
                Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                Console.Write("Enter the arry length n = ");
                isnumber = int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine();
            }


            int[] arry = new int[n];
            int[] arrymin = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arry[i] = random.Next(0, 10);
                Console.WriteLine($" arry[{i}] = {arry[i]}");

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mins > arry[j])
                    {
                        mins = arry[j];
                        arrymin[i] = mins;
                        indexmins = j;
                    }
                }
                arry[indexmins] = 10;
                mins = 10;
            }

            Console.WriteLine("  Placement in ascending order  ");
            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {i + 1}). {arrymin[i]}");

            }


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Main(args);
        }
    }
}