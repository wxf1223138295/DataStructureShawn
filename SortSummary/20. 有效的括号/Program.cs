using System;
using System.Collections.Generic;
using System.Linq;

namespace _20._有效的括号
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
        /// <summary>
        ///  '('，')'，'{'，'}'，'['，']'
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            //把左边的符合入栈 
            //一旦遇到右边的符合，就出栈
            var chars=s.ToCharArray();

            if (chars.Length <= 1)
            {
                return false;
            }

            Stack<string> stack=new Stack<string>();

            Dictionary<string,string> list = new Dictionary<string,string>();
            list.Add("(", ")");
            list.Add("{", "}");
            list.Add("[", "]");
      

            for (int i = 0; i < chars.Length; i++)
            {
                var tt=Convert.ToString(chars[i]);

                if (list.Keys.Any(p=>p==tt))
                {
                    stack.Push(tt);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        var temp = stack.Pop();

                        if (list[temp] != tt)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }

            return stack.Count>0?false:true;
        }
    }
}
