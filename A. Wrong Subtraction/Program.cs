using System;

namespace A._Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            string n =input[0];
            int k =int.Parse(input[1]);
            int count = 0;
            int c = n.Length - 1;
            long e;


            while (count != k)
            {                
                if (n[c] == '0')
                {
                    long num =long.Parse(n);
                    e = num / 10;
                    count++;
                    n = e.ToString();
                    c--;
                }
                 else if (n[c] != '0')
                {
                    long num =long.Parse(n);
                    e = num - 1;
                    count++;
                    n = e.ToString();
                } 
            }
            Console.WriteLine(n);   
        }
    }
}
