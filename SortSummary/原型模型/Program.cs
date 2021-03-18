using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace 原型模型
{
    public class tst2 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class test : IEnumerator<int>
    {
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public int Current { get; }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         

            ConcurrentBag<int> list=new ConcurrentBag<int>();
  
            tst2 s=new tst2();
            
            test t=new test();
      
           //TestEntity te=new TestEntity();
           //te.Arg1 = "11111";
           //te.entity=new TestEntity2{Arg3 ="444444444"};
           //var tt=(TestEntity)te.();

           //tt.Arg1 = "22222";
           //tt.entity.Arg3 = "3333333";
           SunWuKong sunWuKong = new ConcretePrototype("孙悟空");

            var s1 = sunWuKong.Clone() as ConcretePrototype;
            Console.WriteLine("Cloned1:\t" + s1.Id);

            var s2 = sunWuKong.Clone() as ConcretePrototype;
            Console.WriteLine("Cloned2:\t" + s2.Id);


            Console.WriteLine("Hello World!");
        }


        public abstract class SunWuKong
        {
            public string Id { get; set; }
            public SunWuKong(string id)
            {
                this.Id = id;
            }
            // 克隆方法，即孙大圣说“变”
            public abstract SunWuKong Clone();
        }


        public class ConcretePrototype : SunWuKong
        {
            public ConcretePrototype(string id) : base(id)
            {
            }

            public override SunWuKong Clone()
            {
                return (SunWuKong)this.MemberwiseClone();
            }
        }




        public static T Clone<T>(T Obj) where T : class
        {
            object result = null;
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                if (Obj != null)
                {
                    formatter.Serialize(memoryStream, Obj);
                    memoryStream.Position = 0;
                    result = formatter.Deserialize(memoryStream);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                memoryStream.Close();
            }

            return result as T;
        }

        /// <summary>
        /// 复制对象的实例到新的对象
        /// </summary>
        /// <param name="GoldObj">目标实体</param>
        /// <param name="CopyObj">复制实体</param>
        /// <returns></returns>
        public static bool CloneEntity<T>(T GoldObj, T CopyObj) where T : new()
        {
            if (CopyObj == null)
            {
                GoldObj = new T();
                return true;
            }

            if (GoldObj == null)
            {
                GoldObj = new T();
            }

            try
            {
                CopyByProperties(GoldObj, CopyObj, typeof(T).GetProperties());
            }
            catch
            {
                return false;
            }

            return true;
        }

        private static void CopyByProperties(object result, object resource, PropertyInfo[] properties)
        {
            if (result == null || resource == null) return;
            foreach (var p in properties)
            {
                if (p.CanRead && p.CanWrite)
                    p.SetValue(result, p.GetValue(resource, null), null);
            }
        }
    }

    public class TestEntity : ICloneable
    {
        public string Arg1 { get; set; }
        public string Arg2 { get; set; }
        public TestEntity2 entity { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class TestEntity2
    {
        public string Arg3 { get; set; }
    }
}
