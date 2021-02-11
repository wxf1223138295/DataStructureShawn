using System;
using System.Collections.Generic;
using System.Linq;

namespace _37数独
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //{{"5","3",".",".","7",".",".",".","."},{"6",".",".","1","9","5",".",".","."},{".","9","8",".",".",".",".","6","."},{"8",".",".",".","6",".",".",".","3"},{"4",".",".","8",".","3",".",".","1"},{"7",".",".",".","2",".",".",".","6"},{".","6",".",".",".",".","2","8","."},{".",".",".","4","1","9",".",".","5"},{".",".",".",".","8",".",".","7","9"}}
            string[,] test = new string[9, 9] { { "5", "3", ".", ".", "7", ".", ".", ".", "." }, { "6", ".", ".", "1", "9", "5", ".", ".", "." }, { ".", "9", "8", ".", ".", ".", ".", "6", "." }, { "8", ".", ".", ".", "6", ".", ".", ".", "3" }, { "4", ".", ".", "8", ".", "3", ".", ".", "1" }, { "7", ".", ".", ".", "2", ".", ".", ".", "6" }, { ".", "6", ".", ".", ".", ".", "2", "8", "." }, { ".", ".", ".", "4", "1", "9", ".", ".", "5" }, { ".", ".", ".", ".", "8", ".", ".", "7", "9" } };

            Solution s = new Solution();
            s.SolveSudoku(test);

        }
    }

    public class Solution
    {
        private int Maxheight = 9;
        private int MaxWidth = 9;


        public void SolveSudoku1(char[][] board)
        {

        }

        private bool BackTrack1(char[][] board)
        {
            for (int row = 0; row < Maxheight; row++)
            {
                for (int col = 0; col < MaxWidth; col++)
                {
                    //自带的
                    var currentvalue = board[row][col];
                    if (currentvalue != '.') continue;
                    //排除不合法的
                    for (char k = '1'; k <= '9'; k++)
                    {
                        var result = isValid1(board, row, col, k);
                        if (result)
                        {
                            board[row][col] = k;
                            if (BackTrack1(board))
                            {
                                return true;
                            }
                            board[row][col] = '.';
                        }
                    }
                    return false;
                }
            }

            return true;
        }

        bool isValid1(char[][] board, int row, int col, char k)
        {
            //列
            for (int i = 0; i < Maxheight; i++)
            {
                if (board[i][col] ==k)
                {
                    return false;
                }
            }
            //行
            for (int i = 0; i < MaxWidth; i++)
            {
                if (board[row][i] == k)
                {
                    return false;
                }
            }
            //3X3
            //判断在第几格
            var t = row / 3;  //0 0  0  1  1 1   2 2 2
            var r = col / 3;  //0 0  0  1  1 1   2 2 2

            //var p = row % 3;//0 1 2  0 1 2  0 1 2
            //var c = col % 3;//0 1 2  0 1 2  0 1 2


            for (int i = t * 3; i < (t + 1) * 3; i++)
            {
                for (int j = r * 3; j < (r + 1) * 3; j++)
                {
                    if (board[i][j] == k)
                    {
                        return false;
                    }
                }
            }


            return true;
        }

        public void SolveSudoku(string[,] board)
        {
            //创建N*N的棋盘
            string[,] sd = new string[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sd[i, j] = board[i, j];
                }
            }

            BackTrack(sd);


        }
        /// <summary>
        /// 二维递归 不用终止
        /// 递归的下一层的棋盘一定比上一层的棋盘多一个数，等数填满了棋盘自然就终止（填满当然好了，说明找到结果了），所以不需要终止条件！
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool BackTrack(string[,] s)
        {
            for (int row = 0; row < Maxheight; row++)
            {
                //第row行的个数 即列数

                for (int col = 0; col < MaxWidth; col++)
                {
                    //自带的
                    var currentvalue = s[row, col];
                    if (currentvalue != ".") continue;
                    //排除不合法的
                    for (int k = 1; k <= 9; k++)
                    {
                        var result = isValid(s, row, col, k);
                        if (result)
                        {
                            s[row, col] = k.ToString();
                            if (BackTrack(s))
                            {
                                return true;
                            }
                            s[row, col] = ".";
                        }
                    }
                    return false;
                }
            }

            return true;
        }
        bool isValid(string[,] board, int row, int col, int k)
        {

            //列
            for (int i = 0; i < Maxheight; i++)
            {
                if (board[i, col] == k.ToString())
                {
                    return false;
                }
            }
            //行
            for (int i = 0; i < MaxWidth; i++)
            {
                if (board[row, i] == k.ToString())
                {
                    return false;
                }
            }
            //3X3
            //判断在第几格
            var t = row / 3;  //0 0  0  1  1 1   2 2 2
            var r = col / 3;  //0 0  0  1  1 1   2 2 2

            //var p = row % 3;//0 1 2  0 1 2  0 1 2
            //var c = col % 3;//0 1 2  0 1 2  0 1 2


            for (int i = t * 3; i < (t + 1) * 3; i++)
            {
                for (int j = r * 3; j < (r + 1) * 3; j++)
                {
                    if (board[i, j] == k.ToString())
                    {
                        return false;
                    }
                }
            }


            return true;
        }

    }


}
