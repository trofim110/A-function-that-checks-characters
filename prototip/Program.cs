using System;

public class IsDigitSample
{
    public static void Main()
    {
        ConsoleCommands.WordEnter();

        string word;
        word = Console.ReadLine();

        List<char> Word = new List<char>();
        Word=LogicSolution.transferInListAndDeleteLetters(word,Word);

        ConsoleCommands.ListofEnteredDigits(Word);
        Word.Sort();
        ConsoleCommands.ListofEnteredDigits(Word);

    }
    public static class ConsoleCommands
    {
        public static void WordEnter ()
            => Console.WriteLine("Здравствуйте, введите слово");

        public static void inputResult()
            => Console.WriteLine("Результат слова");

        public static void ListofEnteredDigits(List<char> Word )
        {
            Console.WriteLine("Вы ввели такие цифры в своем слове");

            for (int i = 0; i < Word.Count; i++)
            {
                Console.WriteLine(Word[i]);
            }

        }

    }

    public static class LogicSolution
    {
        public static List<char> transferInListAndDeleteLetters(string word, List<char> Word )
        {
            for (int i = 0; i < word.Length; i++)
            {
                Word.Add(Convert.ToChar(word[i]));
            }
            return  DeleteLetters(Word);
        }

        public static List<char> DeleteLetters(List<char> Word )
        {
            for (int i = 0; i < Word.Count; i++)
            {
                if (!char.IsDigit(Word[i]))
                {
                    Word.RemoveAt(i);
                    i--;
                }
            }
            return Word;
        }

    }

}



