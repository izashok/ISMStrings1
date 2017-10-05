using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibRED;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            //1
            bool qq;
            LibRED.Class1.T1(ref s, out qq);
            if (qq==true)
                Console.WriteLine("Время корректное");
            else
                Console.WriteLine("Время некорректное");

            //1

            //2
            bool q;
            LibRED.Class1.T2(ref s, out q);
            if (q == true)
                Console.WriteLine("Дата правильная");
            else
                Console.WriteLine("Дата неправильная");


            //2

            //3

            bool q3;
            LibRED.Class1.T3(ref s, out q3);
            if (q == true)
                Console.WriteLine("IP correct");
            else
                Console.WriteLine("IP incorrect");
            //3


        }
    }
}
