using System;
using System.Collections.Generic;


namespace mean_median
{
    class Program
    {
        static void Main(string[] args)
        {
            double input,n,i,mean,temp,upper,lower;
            double sum= 0.0;
            Console.WriteLine("Enter no. of data in list");
            n = double.Parse(Console.ReadLine());
            List<double> userList = new List<double>();
            for(i=0; i<n;i++)
            {
                Console.WriteLine("Enter " + i + " item");
                input = double.Parse(Console.ReadLine());
                userList.Add(input);

            }
            userList.Sort();
            foreach (var user in userList)
            {
                sum += user;
                
            }

            mean = sum / n;
            Console.WriteLine("Mean= "+mean);
            temp = (n + 1) / 2;
            if (n % 2 != 0)
            { 
                Console.WriteLine("Median= " + userList[Convert.ToInt32(temp-1)]);
            }
            else
            {
                upper = userList[Convert.ToInt32(temp)];
                lower = userList[Convert.ToInt32(temp-1)];
                temp = (upper + lower) / 2;
                Console.WriteLine("Median= " + temp);

            }
            
        }
    }
}
