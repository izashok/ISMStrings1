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


            //3
        }
    }
}
