using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_two_numbers;

    public class  Validationofvalues
    {
        public  int Compares_characters( int a, int b)
        {
            int l=0;
            if ((a>47)&&(a<58)&&(b>47)&&(b<58))   //Если оба из символов не являются буквенными, то вернуть -1
            {
                l--;
            }
            else if (((a>64)&&(b>64)&&(a<91)&&(b<91))||((a>96)&&(b>96)&&(a<123)&&(b<123)))
            {
                l++;   //Если оба символа являются буквенными, и находятся в одном регистре, то вернуть 1

            }



            return l;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите два символа через entr (либо букву либо цифру) ");
            string Value_1, Value_2;
            var c = new Validationofvalues();
            Value_1 = Console.ReadLine();
            Value_2 = Console.ReadLine();


            if (Value_1.Length < 2 || Value_2.Length < 2)  //Проверка ,что пользователь ввел по одному сиволу
            {
                int a, b;
                a=  Value_1[0];
                b=  Value_2[0];
                Console.WriteLine(c.Compares_characters( a, b));
            }
            else
            {
                Console.WriteLine("Введите два символа через entr (либо букву либо цифру) " );
            }
        }
    }
