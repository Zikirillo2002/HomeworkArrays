namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int OddNumbers = 1;
            bool isnumber;

            Console.Write(" Enter your number : n = ");
            isnumber = int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine();

            while (!isnumber || number < 0)
            {
                Console.WriteLine($" An error occurred in the system !!! \n Please enter another number !!! ");
                Console.WriteLine();
                Console.Write(" Enter your number : n = ");
                isnumber = int.TryParse(Console.ReadLine(), out number);
                Console.WriteLine();
            }

            int[] array = new int[number];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = OddNumbers;
                OddNumbers += 2;
                Console.WriteLine($" {i + 1}). array[{i}] = {array[i]}");
                
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Main(args);

        }
    }
}