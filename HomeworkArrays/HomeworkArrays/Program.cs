namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetNumber();

        }

        public static void GetNumber()
        {
            Console.Write(" Enter your age : ");
            bool isnumber = int.TryParse(Console.ReadLine(), out int number);

            while (!isnumber)
            {
                Console.WriteLine(" An error occurred in the system !!! \n Please enter another number. ");
                Console.Write(" Enter your age : ");
                isnumber = int.TryParse(Console.ReadLine(), out number);
            }

            Biography(number);


        }

        public static void Biography(int age)
        {

            Console.WriteLine($" I'm {age} years old.");
        }



    }
}

