using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] t = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int c = i + j;
                    if ((c % 2) != 0)
                    {
                        t[i, j] = 1;
                       

                    }
                    else
                    {
                        t[i, j] = 0;
                        

                    }
                    Console.Write(t[i, j]);
                    
                    
                }
                Console.WriteLine();



            }
            Console.ReadKey();
        }

    }
}
