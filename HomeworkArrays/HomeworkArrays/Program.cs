namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToLowerWord();
        }

        public static void ToLowerWord()
        {
            string word = GetText();

            Console.WriteLine(word.ToLower());
        }

        public static string GetText()
        {

            Console.Write(" Enter your word : ");
            string text = Console.ReadLine();

            return text;

        }
    }

    
}