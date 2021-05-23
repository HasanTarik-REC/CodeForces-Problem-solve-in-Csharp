using System;
using System.Text;

namespace A._Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            char text = input1[0];
            string input = input1.Substring(1);
            string n = text.ToString();
            n=n.ToUpper();
            n = n + input;
            Console.WriteLine(n);
        }
    }
}
