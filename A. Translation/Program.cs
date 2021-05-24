using System;

namespace A._Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int count = 0;
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            char[] t1 = new char[100];
            char[] tt = new char[100];
            char[] ss = new char[100];
            ss = s.ToCharArray();
            t1= t.ToCharArray();
            for ( i =0,j=t1.Length - 1; i < t1.Length; i++, j--)
            {
                tt[i] = t1[j];
            }
            for(int k = 0; k < s.Length; k++)
            {
                if (ss[k] != tt[k])
                {
                    count++;
                    break;
                }      
            }
            if (count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
