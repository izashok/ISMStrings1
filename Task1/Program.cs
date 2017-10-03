using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibSTR;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss;
            int z;
            //1start
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            bool q;
            LibSTR.Class1.Zero(ref s, out q);
            if (q == true)
            { Console.WriteLine("Все скобки закрыты"); }
            else
            { Console.WriteLine("Не все скобки закрыты"); }
            //1end


            //2start

            LibSTR.Class1.One(ref s, out ss, out z);
            Console.WriteLine($"Самое долгое слово \"{ss}\" ");

            //2end


            //3start
            Console.WriteLine($"Количество слов \"{z}\"");
            //3end

            //4start
            int p;
            LibSTR.Class1.Two(ref s, out p);
            Console.WriteLine($"Количество разных слов \"{p}\"");
            //4end

            //5start
            string[] s1s;
            Console.WriteLine("Слова с 2x буквами:");
            LibSTR.Class1.Three(ref s, out s1s);
            foreach (string x in s1s)
            {
                Console.WriteLine($"{x}");
            }
            //5end

            //6start
            string sq;
            LibSTR.Class1.Four(ref s, out sq);
            Console.WriteLine($"Ред. строка:\"{sq}\"");
            //6end

            /*/7start
            string v1;
            LibSTR.Class1.Five(ref s, out v1);
            Console.WriteLine($"Ред. строка:\"{v1}\"");
            /*/
            //8
            string zaza;
            LibSTR.Class1.Six(ref s, out zaza);
            Console.WriteLine($"Ред. строка:\"{zaza} \"");
            //8
        }  

    }
}
