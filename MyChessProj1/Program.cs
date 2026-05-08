using System;

namespace MyChessProj1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8; 
            char[,] matrix = new char[n, n]; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) matrix[i, j] = '*';
                    else matrix[i, j] = '#';
                }
            }

            Console.WriteLine("\nGlxavor:");
            PrintMatrix(matrix, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1) matrix[i, j] = '*';
                    else matrix[i, j] = '#';
                }
            }

            Console.WriteLine("\nOjandak:");
            PrintMatrix(matrix, n);

            Console.ReadKey();
        }

        static void PrintMatrix(char[,] mat, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}