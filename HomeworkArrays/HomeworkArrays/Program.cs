namespace HomeworkArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FindProbel();
        }

        public static void FindProbel()
        {
            string text = GetText();
            string str = "";
            string newText = "";

            for(int i = text.Length - 1; i > 0; i--)
            {
                str += text[i];
            }

            int indexProbelFirst = text.IndexOf(" ");
            int indexProbelEnd = str.IndexOf(" ");

            if (indexProbelEnd > 1)
            {

                for (int i = indexProbelFirst; i < (text.Length - indexProbelEnd); i++)
                {
                    newText += text[i];
                }

                Console.WriteLine(newText);

            }

            else
            {
                Console.WriteLine("_");
            }

            
        }

        public static string GetText()
        {

            Console.Write(" Enter your text : ");

            return Console.ReadLine();

        }
    }
}