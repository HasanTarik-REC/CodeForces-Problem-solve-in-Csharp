using System;

namespace WaterMelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, result;
            w = Convert.ToInt32(Console.ReadLine());
            if (w > 2 && w % 2 == 0)
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
