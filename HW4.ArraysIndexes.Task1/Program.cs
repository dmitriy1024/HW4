using System;

namespace HW4.ArraysIndexes.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int columns = 8;
            int rows = 10;           
            int num = 0;

            var matrix = new MyMatrix(columns, rows);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[j, i] = num++;

            Console.WriteLine("Original matrix : ");
            Console.WriteLine(matrix.ToString());

            matrix.Resize(12, 5);
            Console.WriteLine("Resized matrix : ");
            Console.WriteLine(matrix.ToString());

            Console.ReadKey();
        }
    }
}
