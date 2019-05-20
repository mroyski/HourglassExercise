using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6, 6]
            {
                {1, 1, 1, 0, 0, 0 },
                {0, 1, 0, 0, 0, 0 },
                {1, 1, 1, 0, 0, 0 },
                {0, 0, 2, 4, 4, 0 },
                {0, 0, 0, 2, 0, 0 },
                {0, 0, 1, 2, 4, 0 }
            };

            int rowSize = 4;
            int colSize = 4;
            int largestSum = 0;
            int top = 3;
            int bottom = 3;

            for (int i = 0; i < rowSize; i++)
            {
                int temp = 0;
                int rowStart = 0;

                for (int j = rowStart; j < rowStart + 3; j++)
                {
                    top += array[i,j];
                }
                Console.WriteLine(top);
            }

        }
    }
}
