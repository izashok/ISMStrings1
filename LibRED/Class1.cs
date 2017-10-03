using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibRED
{
    public class Class1
    {
        //1
        public static void ONE(ref string s, out string s1, out string s2)
        {
            s2=null;
            s1 = null;
            Regex stand=new Regex(@"[3]{1}[8]{1}[0]{1}[6,9]{1}[7,8]{1}\d{7}");
            Match m1 = stand.Match(s);
            while (m1.Success)
            {
                s1 +=" "+m1.Value;
                m1 = m1.NextMatch();
            }
            Regex stand2 = new Regex(@"[3]{1}[8]{1}[0]{1}[6,9,7]{1}[3]{1}\d{7}");
            Match m2 = stand2.Match(s);
            while (m2.Success)
            {
                s2 +=m2.Value+ " ";
                m2 = m2.NextMatch();
            }


        }
        //1

        //2
            public static void TWO(ref string s, out bool f)
        {
            string stand = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
                                  
               if (Regex.IsMatch(s, stand, RegexOptions.IgnoreCase))
                {
                f = true;
                }
                else
                {
                f = false;
                }
            }

        //2
        //3
        public static void THREE(ref string s, out string s1)
        {
            s1 = null;
            Regex stand =new Regex(@"\b(0[1 - 9]\.0\d\.19\d{ 2 } |[12]\d\.0\d\.19\d{ 2}| 3[01]\.0\d\.19\d{ 2}| 0[1 - 9]\.0\d\.200\d |[12]\d\.0\d\.200\d | 3[01]\.0\d\.200\d | 0[1 - 9]\.1[0 - 2]\.19\d{ 2}|[12]\d\.1[0 - 2]\.19\d{ 2}| 3[01]\.1[0 - 2]\.19\d{ 2}| 0[1 - 9]\.1[0 - 2]\.200\d |[12]\d\.1[0 - 2]\.200\d | 3[01]\.1[0 - 2]\.200\d | 0[1 - 9]\.1[0 - 2]\.20\d{ 2}|[12]\d\.1[0 - 2]\.20\d{ 2}| 3[01]\.1[0 - 2]\.20\d{ 2}| 0[1 - 9]\.0\d\.20\d{ 2}|[12]\d\.0\d\.20\d{ 2}| 3[01]\.0\d\.20\d{ 2})\b");
            Match m1 = stand.Match(s);

            while(m1.Success)
            {
                s1 += m1.Value + "";
            }
        }
        //3
        //4
        public static void FOUR(ref string s, out string s1)
        {
            s1 = null;
            Regex stand = new Regex(@"ТМ №[1-9]{1}[0-9]{6}");
            Match m1 = stand.Match(s);
            while(m1.Success)
            {

                s1 += m1.Value + " ";
            }

        }
        //4

        //3-1

        //3-1

        //3-2
        public static void T2(ref string s, out bool q)
        {

            //1984-2025
            string stand = @"198[4-9]|199\d|202[0-5]|20[01]\d";
        if (Regex.IsMatch(s, stand, RegexOptions.IgnoreCase))
                {
                q = true;
                }
                else
                {
                q = false;
                }
}
        //3-2
        
        //3-3

        //3-3
    }
}
