using System;
using System.Collections.Generic;
using System.Linq;

namespace N皇后
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.SolveNQueens(8);
        }
    }
    public class Solution
    {

        public IList<IList<string>> results = new List<IList<string>>();

        //列
        public int MaxWith = 0;
        //行
        public int Maxheight = 0;
        public IList<IList<string>> SolveNQueens(int n)
        {
            //创建N*N的棋盘
            string[,] sd=new string[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sd[i,j] = ".";
                }
            }

            MaxWith = n;
            Maxheight = n;
            




            BackTrack(sd, 0);

            return results;
        }

        private void BackTrack(string[,] s, int row)
        {
            if (row == Maxheight)
            {
                List<string> temp = new List<string>();
                for (var i = 0; i < MaxWith; i++)
                {
                    var t = string.Empty;
                   for (int j = 0; j < row; j++)
                   {
                       t = t + s[i,j];
                   }
                   temp.Add(t);
                }
                results.Add(temp);
                return;
            }

            //第row行的个数 即列数

            for (int col = 0; col < MaxWith; col++)
            {
                //排除不合法的
               if(!isValid(s, row, col)) continue ;

               s[row,col] = "Q";
               BackTrack(s, row + 1);
               s[row,col] = ".";
            }
        }

        /// <summary>
        /// 是否可以在 board[row][col] 放置皇后
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        bool isValid(string[,] board, int row, int col)
        {
         
            for (int i = 0; i < Maxheight; i++)
            {
                if (board[i,col]=="Q")
                {
                    return false;
                }
            }

            //左上
            for (int i = row-1,j=col-1; i>=0&&j>=0; i--,j--)
            {
                if (board[i,j] == "Q")
                    return false;
            }


            //右上
            for (int i = row - 1, j = col + 1; i >= 0 && j < Maxheight; i--, j++)
            {
                if (board[i,j] == "Q")
                    return false;

            }

            return true;
        }
    }
}
