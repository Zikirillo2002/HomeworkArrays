namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;
            int k;
            int l;
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

            Console.Write("Enter the number [0 < k < n] K = ");
            isnumber = int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine();

            while (!isnumber || k <= 0 || k >= n)
            {
                Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                Console.Write("Enter the number [0 < k < n] k = ");
                isnumber = int.TryParse(Console.ReadLine(), out k);
                Console.WriteLine();
            }

            Console.Write("Enter the number [0 < l < n] L = ");
            isnumber = int.TryParse(Console.ReadLine(), out l);
            Console.WriteLine();

            while (!isnumber || l <= 0 || l >= n)
            {
                Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                Console.Write("Enter the number [0 < k < n] L = ");
                isnumber = int.TryParse(Console.ReadLine(), out l);
                Console.WriteLine();
            }

            int[] arry = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arry[i] = random.Next(1, n);
                Console.WriteLine($" arry[{i}] = {arry[i]}");

            }
            Console.WriteLine();

            int summa = arry[k] + arry[l];
            arry[k] = summa - arry[k];
            arry[l] = summa - arry[l];

            Console.WriteLine(" ---------------------- New arry ---------------------------------------- ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" arry[{i}] = {arry[i]}");
            }


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Main(args);
        }
    }
}