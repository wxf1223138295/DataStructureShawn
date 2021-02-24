using System;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    ///  饿汉式 ：第一时间创建实例,类加载就马上创建  无需
    ///  懒汉式 ：需要才创建实例，延迟加载
    /// </summary>
    public class MySingleObj
    {
        private MySingleObj()
        {

        }

        public MySingleObj obj = null;
        private readonly object lockobj=new object();

        public MySingleObj GetInstance()
        {
            if (obj == null)
            {
                obj = new MySingleObj();
            }

            return obj;
        }
        /// <summary>
        /// 线程安全
        /// </summary>
        /// <returns></returns>
        public MySingleObj GetInstance1()
        {
            //过滤掉是null的 
            if (obj == null)
            {
                //多个线程 都是null的话让一个进来
                lock (lockobj)
                {
                    //实例化一次
                    if (obj == null)
                    {
                        obj = new MySingleObj();
                    }
                }
               
            }

            return obj;
        }
    }
}
