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
      

        static void Main(string[] args)
        {
            int count = 0;
            int[,] board = new int[N, N];

            //array to 0
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = 0;
                }
            }

            // pointer array
            int[] pointer = new int[N];
            for (int i = 0; i < N; i++)
            {
                pointer[i] = -1;
            }

            //Implementation
            for (int j = 0; ;)
            {
                pointer[j]++;
                
                if (pointer[j] == N)
                {
                    board[pointer[j] - 1, j] = 0;
                    pointer[j] = -1;
                    j--;
                    if (j == -1)
                    {
                        Console.WriteLine("All have been examined...");
                        break;
                    }
                }
                else
                {
                    board[pointer[j], j] = 1;
                    if (pointer[j] != 0)
                    {
                        board[pointer[j] - 1, j] = 0;
                    }
                    if (methods.SolutionCheck(board))
                    {
                        j++;
                        if (j == N)
                        {
                            j--;
                            count++;
                            Console.WriteLine("Solution" + count.ToString() + ":");
                            for (int p = 0; p < N; p++)
                            {
                                for (int q = 0; q < N; q++)
                                {
                                    Console.Write(board[p, q] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }

    }
}
