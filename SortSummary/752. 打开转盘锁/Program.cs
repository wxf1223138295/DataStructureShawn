using System;
using System.Collections.Generic;
using System.Linq;

namespace _752._打开转盘锁
{
    class Program
    {
        static void Main(string[] args)
        {
            //["8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888"]
            string[] arry=new string[]{ "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" }; 
           Solution s=new Solution();
           s.OpenLock(arry, "8888");
        }
    }

    public class Node
    {
        public IList<Node> childs { get; set; }
        public int val { get; set; }

        public Node(int _val)
        {
            val = _val;
        }

    }
    public class Solution
    {
        private string UpOne(string str,int j)
        {
            var @char = str.ToCharArray();
            if (@char[j] == '9')
            {
                @char[j] = '0';
            }
            else
            {
                @char[j] = Convert.ToChar(Convert.ToInt32(@char[j]) + 1);
            }

            return new string(@char);
        }

        private string DownOne(string str,int j)
        {
            var @char = str.ToCharArray();
            if (@char[j] == '0')
            {
                @char[j] = '9';
            }
            else
            {
                @char[j] = Convert.ToChar(Convert.ToInt32(@char[j]) - 1);
            }

            return new string(@char);
        }
        public int OpenLock(string[] deadends, string target)
        {
            var deth = deadends.ToList();
            Queue<string> queue = new Queue<string>();


            queue.Enqueue("0000");

            //暂存防止走重复路
            List<string> visited=new List<string>();
            visited.Add("0000");
            int deep = 0;

            while (queue.Count>0)
            {
                var len = queue.Count;

                for (int i = 0; i < len; i++)
                {
                    var current = queue.Dequeue();
                   

                    if (deth.Contains(current))
                    {
                        continue;
                    }

                    if (target == current)
                    {
                        return deep;
                    }

                    for (int j = 0; j < 4; j++)
                    {
                        string up = UpOne(current, j);
                        //判断之前有没有拨到过
                        if (!visited.Any(p => p == up))
                        {
                            queue.Enqueue(up);
                            visited.Add(up);
                        }

                        string down = DownOne(current, j);
                        if (!visited.Any(p => p == down))
                        {
                            queue.Enqueue(down);
                            visited.Add(down);
                        }
                    }
                }

                deep++;
            }

            return -1;
        }
    }
}
