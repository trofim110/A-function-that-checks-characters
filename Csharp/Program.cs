using System.Collections.Immutable;

public static class IsDigitSample
{
    public static void Main()
    {
        ConsoleCommands.WordEnter();

        string word=Console.ReadLine();

        List<char> Wordchar = new List<char>();
        Wordchar.AddRange(word.Select(i=>Convert.ToChar(i)));
        Wordchar = LogicSolution.DeleteLetters(Wordchar);
        // Перевел строку в список char, удалил все буквенные элементы


        List<string> WWordString = new List<string>();
        WWordString.AddRange(Wordchar.Select((c=>c.ToString())));
        // Перевел из Char в string

        List<int> WordInt = new List<int>();
        WordInt.AddRange(WWordString.Select(i=>Convert.ToInt32(i)));
        // Перевел из string в int

        Dictionary<int,int> listofDigits=new Dictionary<int,int>();
        LogicSolution.ConvertDictionary(WordInt,listofDigits);
        // Добавил в словарь  отсортировал и вывел на экран результат

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
                Console.WriteLine($"Вы ввели число {VARIABLE.Key}---  столько =>  --{VARIABLE.Value}   ");
            }

        }

    }
    public static class LogicSolution
    {
        public static List<char> DeleteLetters(List<char> Wordchar )
        {
            for (int i = 0; i < Wordchar.Count; i++)
            {
                if (!char.IsDigit(Wordchar[i]))
                {
                    Wordchar.RemoveAt(i);
                    i--;
                }
            }
            return Wordchar;
        }

        public static void ConvertDictionary(List<int> WordInt,Dictionary<int, int> listofDigits)
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
            ConsoleCommands.inputResult();
            ConsoleCommands.DataOutput(listofDigits);

        }

    }

}



