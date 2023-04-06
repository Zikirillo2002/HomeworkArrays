namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int maxnumber = 0;
            int minnumber = 10 ;
            bool isnumber;

            Console.Write("Enter your number : m = ");
            isnumber = int.TryParse(Console.ReadLine(), out int m);

            while (!isnumber)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write("Enter your number : m = ");
                isnumber = int.TryParse(Console.ReadLine(), out m);
            }

            Console.Write("Enter your number : n = ");
            isnumber = int.TryParse(Console.ReadLine(), out int n);

            while (!isnumber)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write("Enter your number : n = ");
                isnumber = int.TryParse(Console.ReadLine(), out n);
            }

            Random random = new Random();
            int[,] array = new int[m, n];

            for(int i = 0; i < m; i++)
            {

                for(int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(-10, 10);
                    Console.Write($"  {array[i, j]}  ");
                }
                Console.WriteLine();
            }

            for(int i = 0; i < m; i++)
            {

                for(int j = 0; j < n; j++)
                {
                    if (maxnumber < array[i, j])
                    {
                        maxnumber = array[i, j];
                    } 
                    if (minnumber > array[i, j])
                    {
                        minnumber = array[i, j];
                    }  
                }
            }

            Console.WriteLine($" MaxNumber = {maxnumber}");
            Console.WriteLine($" MinNumber = {minnumber}");


        }
    }
}