using System;
public class sum_diff
{
    public static void Main()
    {
        int i, j, n,m;
        int[,] arr1 = new int[50, 50];
        int[,] brr1 = new int[50, 50];
        int[,] crr1 = new int[50, 50];

        Console.Write("\n\naddition and difference  of two Matrices :\n");
        Console.Write("-----------------------------------------\n");
        Console.Write("Input the row of the square matrix (less than 5): ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the column of the square matrix (less than 5): ");
        m = Convert.ToInt32(Console.ReadLine());

        /* Stored values into the array*/
        Console.Write("Input elements in the first matrix :\n");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("Input elements in the second matrix :\n");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                brr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nThe First matrix is :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < m; j++)
                Console.Write("{0}\t", arr1[i, j]);
        }

        Console.Write("\nThe Second matrix is :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < m; j++)
                Console.Write("{0}\t", brr1[i, j]);
        }
        /* calculate the sum of the matrix */
        for (i = 0; i < n; i++)
            for (j = 0; j < m; j++)
                crr1[i, j] = arr1[i, j] + brr1[i, j];
        Console.Write("\nThe Addition of two matrix is : \n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < m; j++)
                Console.Write("{0}\t", crr1[i, j]);
        }
        Console.Write("\n\n");
        /* calculate the diff of the matrix */
        for (i = 0; i < n; i++)
            for (j = 0; j < m; j++)
                crr1[i, j] = arr1[i, j] - brr1[i, j];
        Console.Write("\nThe Difference of two matrix is : \n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < m; j++)
                Console.Write("{0}\t", crr1[i, j]);
        }
        Console.Write("\n\n");
    }
}