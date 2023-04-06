namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;
            int k;
            bool numberfind = false;
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

            Console.Write("Enter the number K = ");
            isnumber = int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine();

            while (!isnumber || k <= 0 )
            {
                Console.WriteLine($"An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                Console.Write("Enter the number k = ");
                isnumber = int.TryParse(Console.ReadLine(), out k);
                Console.WriteLine();
            }


            int[] arry = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arry[i] = random.Next(1, 2 * k);
                Console.WriteLine($" arry[{i}] = {arry[i]}");

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (arry[i] == k)
                {
                    numberfind = true;
                }
            }

            if (numberfind) Console.WriteLine(" Arrys contain the number you entered ");

            else Console.WriteLine(" Arrys do not contain the number you entered ");


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Main(args);
        }
    }
}