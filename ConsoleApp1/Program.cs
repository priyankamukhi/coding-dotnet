using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((j)+"");
                }      

                Console.WriteLine();
            }
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
