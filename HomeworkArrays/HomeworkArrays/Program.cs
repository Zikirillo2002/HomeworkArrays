namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
           HowManyRooms();   
        }

        public static void HowManyRooms()
        {
            int number = GetNumber();
            int firstNumber = number;
            int rooms = 0;

            while (number > 0)
            {
                number /= 10;
                rooms++;

            }

            Console.WriteLine($" {firstNumber} is number {rooms} rooms.");
        }

        public static int GetNumber()
        {
            Console.Write(" Enter your number : ");
            bool isnumber = int.TryParse(Console.ReadLine(), out int number);

            while (!isnumber || number <= 0)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number.");
                Console.Write(" Enter your number : ");
                isnumber = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}