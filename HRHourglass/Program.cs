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

            for (int i = 0; i < 1; i++)
            {
                int temp = 0;

                for (int k = 0; k < rowSize; k++)
                {
                    int top = 0;
                    int bottom = 0;

                    for (int j = k; j < k + 3; j++)
                    {
                        top += array[i, j];
                    }
                    Console.WriteLine(top);
                }

            }

        }
    }
}
