namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isnumber;

            Console.Write(" Enter your number : m = ");
            isnumber = int.TryParse(Console.ReadLine(), out int m);

            while (!isnumber || m < 0)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write(" Enter your number : m = ");
                isnumber = int.TryParse(Console.ReadLine(), out  m);
            }

            Console.Write(" Enter your number : n = ");
            isnumber = int.TryParse(Console.ReadLine(), out int n);

            while (!isnumber || n < 0)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write(" Enter your number : n = ");
                isnumber = int.TryParse(Console.ReadLine(), out  n);
            }

            Console.Write(" Enter your number : k = ");
            isnumber = int.TryParse(Console.ReadLine(), out int k);

            while (!isnumber)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write(" Enter your number : k = ");
                isnumber = int.TryParse(Console.ReadLine(), out  k);
            }

            Random random = new Random();
            int[,] array = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(-2*k, 2*k);
                    Console.Write($"  {array[i, j]}  ");
                }
                Console.WriteLine();
            }

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (array[i,j] == k)
                    {
                        if(j == 0)
                        {
                            array[i, j++] = 0;
                        }

                        else
                        {
                            array[i, j - 1] = 0; 
                        }
                    }
                }
            }

            Console.WriteLine(" ---------------------------------------------- ");


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  {array[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}