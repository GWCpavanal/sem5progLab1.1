using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem5progLab1
{
    public class Matrix
    {
        int Rows = 4;
        int Columns = 5;
        public double[,] array = new double[4, 5] { 
            { 1, 1, 1, 1, 1 }, 
            { 1, 1, 1, 1, 1 }, 
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1}};
        public double maxNum;
        public int MaxRow = 0, MaxColumn = 0;
        public void RandomArray()// генерация матрицы с случайными числами
        {
            Random random = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = random.NextDouble() * (10 + 10) - 10; // рандом вещественных чисел от - 10 до 10 с 4 цифрами после запятой
                    array[i, j] = Math.Round(array[i, j], 4);
                }
            }
        }

        public void SearchMax() // поиск максимального
        {
            maxNum = array[1, 1];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (array[i, j] > maxNum)
                    {
                        maxNum = array[i, j];
                        MaxRow = i;
                        MaxColumn = j;
                    }
                }
            }
        }
        public void Reverse()
        {
            double number;
            number = array[0, 0];
            array[0, 0] = array[MaxRow, MaxColumn];
            array[MaxRow, MaxColumn] = number;
        }

    }
}
