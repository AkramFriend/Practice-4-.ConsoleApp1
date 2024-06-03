using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4_.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите количество строк для матрицы: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество столбцов для матрицы: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
