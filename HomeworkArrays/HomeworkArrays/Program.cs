namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int summa = 0;
            int multiplication = 1;
            bool isnumber;

            Console.Write(" Enter your number : m = ");
            isnumber = int.TryParse(Console.ReadLine(), out int m);

            while (!isnumber)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Pleace enter another number. ");
                Console.Write(" Enter your number : m = ");
                isnumber = int.TryParse(Console.ReadLine(), out m);
            }

            Console.Write(" Enter your number : n = ");
            isnumber = int.TryParse(Console.ReadLine(), out int n);

            while (!isnumber)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Pleace enter another number. ");
                Console.Write(" Enter your number : n = ");
                isnumber = int.TryParse(Console.ReadLine(), out n);
            }

            Console.Write(" Enter your number : k = ");
            isnumber = int.TryParse(Console.ReadLine(), out int k);

            while (!isnumber || k < 0 || k > m)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Pleace enter another number. ");
                Console.Write(" Enter your number : k = ");
                isnumber = int.TryParse(Console.ReadLine(), out k);
            }

            int[,] array = new int[m, n];
            Random random = new Random();

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 10);
                    Console.Write($"  {array[i, j]}  ");
                }
                Console.WriteLine();
            }

            for(int i = 0; i < n; i++)
            {

                summa += array[(k - 1), i];
                multiplication *= array[(k - 1), i];
                
            }

            Console.WriteLine($" Summa(k) = {summa}  ");
            Console.WriteLine($" Multiplication(k) = {multiplication}  ");
            Console.WriteLine();
        }
    }
}