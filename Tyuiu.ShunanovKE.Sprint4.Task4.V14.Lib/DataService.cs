using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShunanovKE.Sprint4.Task4.V14.Lib
{
    public class DataService : ISprint4Task4V14
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            int[,] res = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0) res[i, j] = matrix[i, j];
                    else res[i, j] = 0;
                }
            }
            return res;
        }
    }
}
