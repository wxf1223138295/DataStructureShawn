using System;
using System.Collections;
using System.Collections.Generic;

namespace _150._逆波兰表达式求值
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
        public int EvalRPN(string[] tokens)
        {
            //+, -, *, / 
            var stack =new Stack<dynamic>();

           
            for (int i = 0; i < tokens.Length; i++)
            {
                
                var iscan=int.TryParse(tokens[i],out int result);

                if (iscan)
                {
                    stack.Push(result);
                }
                else
                {
                    switch (tokens[i])
                    {
                        case "+":
                            var result1 = stack.Pop();
                            var result2 = stack.Pop();
                            var sum = (int) result1 + (int) result2;
                            stack.Push(sum);
                            break;
                        case "-":
                            var result3 = stack.Pop();
                            var result4 = stack.Pop();
                            var minus = result4 - result3;
                            stack.Push(minus);
                            break;
                        case "*":
                            var result5 = stack.Pop();
                            var result6 = stack.Pop();
                            var mult = result5 * result6;
                            stack.Push(mult);
                            break;
                        case "/":
                            var result7 = stack.Pop();
                            var result8 = stack.Pop();
                            var div = result8 / result7;
                            stack.Push(div);
                            break;
                    }
                }
                
            }

            var test = (int) stack.Pop();

            return test;

        }
    }
}
