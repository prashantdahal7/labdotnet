using System;

namespace classpratice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number which you want to display its multiplication");
            int n = int.Parse(Console.ReadLine());
            int i, temp;
            for (i =1; i <= 10; i++)
            {
                temp = n * i;
                Console.WriteLine(n + "*"+i+"= " + temp);
            }
        }
    }
}
