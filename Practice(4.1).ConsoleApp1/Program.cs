using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4._1_.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите количество строк для 1-ой матрицы: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество столбцов для 1-ой матрицы: ");
            int col1 = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество строк для 2-ой матрицы: ");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество столбцов для 2-ой матрицы: ");
            int col2 = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество строк для результатной матрицы: ");
            int row3 = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество столбцов для результатной матрицы: ");
            int col3 = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[row1, col1];
            int[,] matrixB = new int[row2, col2];
            int[,] matrixC = new int[row3, col3];
            Random r = new Random();
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    matrixA[i, j] = r.Next(10);
                    Console.Write($"{matrixA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    matrixB[i, j] = r.Next(10);
                    Console.Write($"{matrixB[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < row3; i++)
            {
                for (int j =0; j < col3; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write($"{matrixC[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
