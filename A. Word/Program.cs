using System;

namespace A._Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            int p = 0;
            for(int i = 0; i < input.Length; i++)
            {
                for (int j = 65;j<= 90; j++)
                {
                    if (input[i] == j)
                        count++;
                }
                for(int k = 97; k <= 122; k++)
                {
                    if (input[i] == k)
                    {
                        p++;
                    }
                }
            }
            if (count == p)
            {
                input = input.ToLower();
            }
            else if (count > p)
            {
                input = input.ToUpper();
            }
            else if (p > count)
            {
                input = input.ToLower();
            }
            Console.WriteLine(input);
        }
    }
}
