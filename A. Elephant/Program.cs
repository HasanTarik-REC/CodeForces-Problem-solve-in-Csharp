using System;

namespace A._Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var input = Console.ReadLine();
            int x = int.Parse(input);
            while (x != 0)
            {
                if (x >= 5)
                {
                    int p = x / 5;
                    x = x % 5;
                    count = p;
                }
                else if (x == 4)
                {
                    count++;
                    x = 0;
                }
                else if (x == 3)
                {
                    count++;
                    x = 0;
                }
                else if (x == 2)
                {
                    count++;
                    x = 0;
                }
                else if (x == 1)
                {
                    count++;
                    x = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
