namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;
            int total = 0;
            int count = 0;
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
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arry[i] = random.Next(1, 10);
                Console.WriteLine($" arry[{i}] = {arry[i]}");

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (arry[i] % 2 == 0) total += arry[i];

                else
                {
                    count++;
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($" Result : {total} ");
            }

            else Console.WriteLine($" Result : {total - arry[0] - arry[n - 1]} ");


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Main(args);
        }
    }
}