using System;
using System.Collections.Generic;
using System.Linq;

namespace _210._课程表_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            List<List<int>> lists=new List<List<int>>();
            for (var i = 0; i < prerequisites.Length; i++)
            {
                lists.Add(prerequisites[i].ToList()); 
            }

            List<int> temp=new List<int>();

            Queue<int> queue=new Queue<int>();

            lists.ForEach(p =>
            {
                queue.Enqueue(p[0]);
            });

            while (queue != null)
            {
                var count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    var reuslt = queue.Dequeue();

                    temp.Add(reuslt);
                }
               


            }

        }
    }
}
