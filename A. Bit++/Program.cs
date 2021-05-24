using System;

namespace A._Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x = 0;
            var input = Console.ReadLine();
            int n = int.Parse(input);
            char[] name = new char[3];
            while (count != n)
            {
                var p=(Console.ReadLine());
                name=p.ToCharArray();
                if (name[0] == 'x')
                {
                    if (name[1] == '+')
                    {
                        x++;
                    }
                    else if (name[1] == '-')
                    {
                        x--;
                    }
                }
                else
                {
                    if (name[0] == '+')
                    {
                        ++x;
                    }
                    else if (name[0] == '-')
                    {
                        --x;
                    }
                }
                count++;
            }
            Console.WriteLine(x);
        }
    }
}
