namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ReverseText();
        }

        public static void ReverseText()
        {
            string text = GetText();
            string str = "";

            for(int i = text.Length - 1; i >= 0 ;i--)
            {
                str += text[i];
            }

            Console.WriteLine(str);
        }

        public static string GetText()
        {
            Console.Write(" Enter your text : ");

            return Console.ReadLine();

        }
    }
}