using System;

namespace A._Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0;
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            char[] nn = new char[n];
            nn = s.ToCharArray();
            for(int i = 0; i < n; i++)
            {
                if (nn[i] == 'A')
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            if(count1>count2)
                Console.WriteLine("Anton");
            else if(count2>count1)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");

        }
    }
}
