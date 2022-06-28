namespace A_function_that_checks_character;

public static class Utils
{
    public static int ComparesCharacters(char a, char b)
    {
        if (!char.IsLetter(a) || !char.IsLetter(b)) {
            return -1;
        }

        return char.IsUpper(a) && char.IsUpper(b) ? 1 : 0;
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        ConsoleCommands.PrintWelcomeMessage();

        var (charA, charB) = ConsoleCommands.AskUserForInput();

        ConsoleCommands.PrintResult(Utils.ComparesCharacters(charA, charB));
    }

    private static class ConsoleCommands {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Введите два символа через entr (либо букву либо цифру) ");
        }

        public static (char, char) AskUserForInput()
        {
            Console.WriteLine("Введите первый симовл");
            var charA = Console.ReadKey().KeyChar;

            Console.WriteLine("Введите второй симовл");
            var charB = Console.ReadKey().KeyChar;

            return (charA, charB);
        }

        public static void PrintResult(int comparisonResult)
        {
            Console.WriteLine($"Реузльтат сравенения: {comparisonResult}");
        }
    }
}