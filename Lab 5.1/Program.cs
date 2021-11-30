using System;

namespace Lab_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[7];
            float s = 0;
            t[0] = Convert.ToInt32(Console.ReadLine());
            t[1] = Convert.ToInt32(Console.ReadLine());
            t[2] = Convert.ToInt32(Console.ReadLine());
            t[3] = Convert.ToInt32(Console.ReadLine());
            t[4] = Convert.ToInt32(Console.ReadLine());
            t[5] = Convert.ToInt32(Console.ReadLine());
            t[6] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<7; i++)
            {
                s += t[i];
            }
                
            Console.WriteLine(s / 2);
            Console.ReadKey();
        }
    }
}
