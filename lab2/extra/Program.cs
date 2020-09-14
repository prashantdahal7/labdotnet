using System;



namespace extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,n=0;        
            do
            {
                Console.WriteLine("Random no. has been generated");
                Random r = new Random();
                int num = r.Next(10, 50);
                Console.WriteLine("Random no. for 5 times");
                for (int i = 0; i <= 5 && n != num; i++)
                {
                    n = int.Parse(Console.ReadLine());
                    if (num == n)
                        Console.WriteLine("Hooray! You won.");
                    else
                    {
                        Console.WriteLine("Oh no! You lost");
                        Console.WriteLine("Try again");
                    }
                }
                Console.WriteLine(" Random no is: "+num);
                Console.WriteLine(" for playing again press 1");
                m = int.Parse(Console.ReadLine());
            }
            while (m == 1);
        }
    }
}
