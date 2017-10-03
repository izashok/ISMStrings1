using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSTR
{
    public class Class1
    {
        //1start
        public static void Zero(ref string s, out bool q)
        {
            q = false;
            int k1 = 0;
            int k2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                bool q1 = false;
                q1 = s.Substring(i, 1).Equals("(");
                if (q1 == true)
                {
                    k1 += 1;
                }
                bool q2 = false;
                q2 = s.Substring(i, 1).Equals(")");
                if (q2 == true)
                {
                    k2 += 1;
                }


            }
            if (k1 == k2)
                q = true;

        }
        //1end

        //2start
        public static void One(ref string s, out string ss, out int z)
        {
            int k = 0;
            ss = "";
            z = 0;
            string[] s1 = s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string q in s1)
            {
                //3start
                z++;
                //3end

                if (k < q.Length)
                {
                    k = q.Length;
                    ss = q;
                }


            }
        }

        //2end

        //4start
        public static void Two(ref string s, out int z)
        {
            z = 0;

            string[] s1 = s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string q in s1)
            {
                int k = 0;
                foreach (string q1 in s1)
                {
                    if (q == q1)
                    {
                        k++;
                    }

                }
                if (k == 1)
                    z++;
            }
        }

        //4end

        //5start
        public static void Three(ref string s, out string[] s1s)
        {

            string[] s1 = s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string s2s = " ";
            foreach (string q in s1)
            {
                if (q.Length > 1)
                {
                    for (int i = 0; i + 1 < q.Length; i++)

                    {

                        bool q1 = false;
                        q1 = q.Substring(i, 1).Equals(q.Substring(i + 1, 1));
                        if (q1 == true)
                        {
                            s2s = s2s.Insert(s2s.Length, " ");
                            s2s = s2s.Insert(s2s.Length, q);
                            break;
                        }
                    }
                }
                else
                    continue;
            }
            s1s = s2s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);


        }
        //5end

        //6start

        public static void Four(ref string s, out string sq)
        {
            sq = "";
            string[] str = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            sq = String.Join(" ", str);
            sq = sq.Trim();
        }
        //6end
        //7start
        /*
        public static void Five(ref string s, out string s1s)
        {
            string f1;
            s1s = null;
            char fx;
            int fn=0;
            string[] s1 = s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string q in s1)
            {
                
                fn = q.Length-1;
                f1 = q;
             
                f1 = f1.Replace(f1[0], q[fn]);
                f1 = f1.Replace(f1[fn],q[0]);
                s1s = s1s + " " + f1;
                
            }
            
            //7end
            }
            */

        //8start
        public static void Six(ref string s, out string zaza)
        {
            zaza=null;
            bool qq;
            int op=0;
            string[] a = { "у", "е", "ї", "і", "а", "о", "є", "я", "и", "ю" };
            string[] s1 = s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string q in s1)
            {
                int L = 0;
                for (int i = 0; i < q.Length; i++)
                {
                    for (int x = 0; x < a.Length; x++)
                    {
                        qq = false;
                        qq = s.Substring(i, 1).Equals(a[x]);
                        if (qq == true)
                        {
                            L += 1;
                        }
                                                
                            
                    }
                     op = q.Length - L;
                   
                }

                if (op % 2 != 0)
                {
                    zaza +=q;

                }


            }
            }            
        //8end
   }
}
