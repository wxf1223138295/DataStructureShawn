using System;

namespace _67._把字符串转换成整数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.StrToInt(" -42");
        }
    }

    public class Solution
    {
        public int StrToInt(string str)
        {
            int i = 0;
            int flag = 1;//默认正数
            int res = 0;
            str = str.Trim();
 if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
           

            if (str[i] == '-')
            {
                flag = -1;
            }

            if (str[i] == '-' || str[i] == '+')
            {
                i++; //往后挪一位
            }

            for (int j = i; j < str.Length; j++)
            {
                if (isdigit(str[j]))
                {
                    //溢出判断
                    if ((res > Int32.MaxValue / 10) || (res == Int32.MaxValue / 10 && str[j] - '0' > 7))
                    {
                        return flag == 1 ? Int32.MaxValue : Int32.MinValue;
                    }
                    res = res * 10 + (str[j] - '0');
                }
                else
                {
                    break;
                }
            }

            return flag*res;
        }

        private bool isdigit(char c)
        {
            var t1= '0' <= c ;
            var t2 = c <= '9';

            return t1 && t2;
        }
    }
}
