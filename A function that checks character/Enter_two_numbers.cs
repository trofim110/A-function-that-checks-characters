using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_two_numbers
{
    public class  Validationofvalues
    {
        public  static int Compares_characters(ref string Value_1,ref string Value_2)
        {
            return String.Compare( Value_1, Value_2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два символа через entr (либо букву либо цифру) ");
            string Value_1, Value_2;
            Value_1 = Console.ReadLine();
            Value_2 = Console.ReadLine();
            if (Value_1.Length < 2 || Value_2.Length < 2)  //Проверка ,что пользователь ввел по одному сиволу
            {
                Console.WriteLine(Compares_characters(ref Value_1,ref Value_2));
            }
            else
            {
                Console.WriteLine("Введите два символа через entr (либо букву либо цифру) " );
            }
        }
    }
}