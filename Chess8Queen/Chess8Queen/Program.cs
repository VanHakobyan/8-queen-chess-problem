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
            //fourth
            for (int i = 0, j = 1; j < N; j++)
            {
                int sum = 0;
                for (int p = i, q = j; q >= 0; p++, q--)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }


            //fifth
            for (int i = 1, j = N - 1; i < N - 1; i++)
            {
                int sum = 0;
                for (int p = i, q = j; p < N; p++, q--)
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
                    if (SolutionCheck(board))
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
