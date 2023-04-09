namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MinAndMax();
        }

        public static void MinAndMax()
        {
            Console.Write(" Enter your number x = ");
            int x = GetNumber();
            Console.Write(" Enter your number y = ");
            int y = GetNumber();
            int c = x + y;

            if(x < y)
            {
                x = y;
                y = c - x;
            }

            Console.WriteLine($" Max number : x = {x} \n Min number : y = {y}");
           
        }

        public static int GetNumber()
        {
            bool isnumber;

            isnumber = int.TryParse(Console.ReadLine(), out int number);

            while (!isnumber)
            {
                Console.WriteLine(" An error occured in the system \n Please enter another number.");
                Console.Write(" Enter your number : ");
                isnumber = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}