namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($" {FindCentury() + 1} centuries ");
        }

        public static int FindCentury()
        {
            int number = GetNumber();

            int century = number / 100;

            return century;
        }

        public static int GetNumber()
        {
            Console.Write(" Enter your number : ");
            bool isnumber = int.TryParse(Console.ReadLine(), out int number);

            while(!isnumber || number <= 0)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write(" Enter your number : ");
                isnumber = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}