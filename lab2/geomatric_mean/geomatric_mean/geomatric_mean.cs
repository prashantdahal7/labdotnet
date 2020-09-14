using System;
using System.Collections.Generic;

namespace geomatric_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            double input, n, i, mean, product=1.0;
            Console.WriteLine("Enter no. of data in list");
            n = double.Parse(Console.ReadLine());
            List<double> userList = new List<double>();
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + i + " item");
                input = double.Parse(Console.ReadLine());
                userList.Add(input);

            }
            foreach (var user in userList)
            {
                product *= user;

            }
            mean= Math.Pow(product, 1.0 / n);
            Console.WriteLine("Geomatric mean :" + mean);
        }
    }
}
