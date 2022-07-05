using System.Collections.Immutable;

public class IsDigitSample
{
    public static void Main()
    {
        ConsoleCommands.WordEnter();

        string word=Console.ReadLine();

        List<char> Wordchar = new List<char>();
        Wordchar=LogicSolution.transferInListAndDeleteLetters(word,Wordchar);
        Wordchar.Sort();        // Перевел строку в список char, удалил все буквенные элементы


        List<string> WWordString = new List<string>();
        WWordString.AddRange(Wordchar.Select((c=>c.ToString())));
        // Перевел из Char в string

        List<int> WordInt = new List<int>();
        WordInt.AddRange(WWordString.Select(i=>Convert.ToInt32(i)));
        // Перевел из string в int

        Dictionary<int,int> listofDigits=new Dictionary<int,int>();
        LogicSolution.ConvertDictionary(WordInt,listofDigits);
        // Добавил в словарь и отсортировал

        ConsoleCommands.inputResult();
        ConsoleCommands.DataOutput(listofDigits);

    }
    public static class ConsoleCommands
    {
        public static void WordEnter ()
            => Console.WriteLine("Здравствуйте, введите слово");

        public static void inputResult()
            => Console.WriteLine("Результат слова");

        public static void DataOutput(Dictionary<int, int> listofDigits)
        {

            foreach (var VARIABLE in listofDigits.OrderBy(VARIABLE=>VARIABLE.Value))
            {
                Console.WriteLine($"Вы ввели число {VARIABLE.Key}---  столько раз  --{VARIABLE.Value}   ");
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

        public static Dictionary<int, int> ConvertDictionary(List<int> WordInt,Dictionary<int, int> listofDigits)
        {

            for (int i = 0; i <= 13; i++)
            {
                if ((WordInt.FindAll(e => e == i).Count) == 0)
                {
                    continue;
                }
                else
                {
                    listofDigits.Add(i, WordInt.FindAll(e => e == i).Count);
                }

            }

            return listofDigits;
        }

    }

}



