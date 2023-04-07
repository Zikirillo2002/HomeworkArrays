namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
        }

        public static int ArraySumma()
        {

            Random random = new Random();
            int[][] array = new int[random.Next(1,10)][];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new int[random.Next(1, 10)];
            }


        }
    }
}