namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SignFind();
          
        }

        public static void SignFind()
        {
            int number = GetNumber();

            if (number < 0)
                Console.WriteLine($" {number} is negative number ");
            else
                Console.WriteLine($" {number} is positive number ");
        }

        public static int GetNumber()
        {
            bool isnumber;

            Console.Write(" Enter your number : ");
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

