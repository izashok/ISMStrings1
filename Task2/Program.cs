using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibRED;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Введите строку");
                string s = Console.ReadLine();

            //1
            string s1,s2;
            LibRED.Class1.ONE(ref s, out s1,out s2);
            Console.WriteLine($"Номера Киевстар \n {s1}");
            Console.WriteLine($"Номера Лайф \n {s2}");
            //1



            //2
            bool f;
            LibRED.Class1.TWO(ref s, out f);
            if (f == true)
                Console.WriteLine("email правильный");
            else
                Console.WriteLine("email неверный");
            //2

            //3
            string ss1 = null;
            LibRED.Class1.THREE(ref s, out ss1);
            Console.WriteLine($"Правильные даты {ss1}");
            //3
            //4

            string ss2 = null;
            LibRED.Class1.FOUR(ref s, out ss2);
            Console.WriteLine($"Студаки {ss2}");
            //4
        }
    }
}
