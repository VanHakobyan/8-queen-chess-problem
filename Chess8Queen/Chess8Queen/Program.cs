using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess8Queen
{


    class Program
    {
        const int N = 8;
        public static bool SolutionCheck(int[,] board)
        {
           

            //first
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum = sum + board[i, j];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
           

            //second
            for (int i = 0, j = N - 2; j >= 0; j--)
            {
                int sum = 0;
                for (int p = i, q = j; q < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //third
            for (int i = 1, j = 0; i < N - 1; i++)
            {
                int sum = 0;
                for (int p = i, q = j; p < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }


           


            return true;
        }



        static void Main(string[] args)
        {
            
        }

    }
}
