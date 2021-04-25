using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AsyncLocalTest
{

    class Program
    {
        public static AllDifferentItemsResponse entity = new AllDifferentItemsResponse();
        static void Main(string[] args)
        {

            //var list1=new List<int>{1,2,3,4,6};

            //var list2=new List<int>{2,3,4,5};

            //HashSet<int> h1 = new HashSet<int>(list1);
            //HashSet<int> h2 = new HashSet<int>(list2);

            //var tt=h1.Except(list2).ToList();




            var path =
                @"D:\SynyiProject\synyi-cqm-medicalqualitymonitor-devtool\src\Synyi.CQM.MedicalQualityMonitor.DevTool.Service\test\新建文件夹";

            var jsonfile = Path.Combine(path, "new.json");

            var jsonfile1 = Path.Combine(path, "old.json");


            var strjsonnew = File.ReadAllText(jsonfile);
            var strjsonoldw = File.ReadAllText(jsonfile1);


            var jsonnew = JToken.Parse(strjsonnew).SelectToken("data");
            var jsonold = JToken.Parse(strjsonoldw).SelectToken("data");

            var tnew = jsonnew.Children();
            var told = jsonold.Children();

            Func(tnew, told);

            Console.ReadKey();

        }

        public static void Func(IEnumerable<JToken> tnew, IEnumerable<JToken> told)
        {
            if (tnew == null || told == null)
            {
                return;
            }
            //将新的
            Dictionary<string, JToken> dicnew = new Dictionary<string, JToken>();

            foreach (var item in tnew)
            {
                var result = item.SelectToken("no");

                dicnew.Add(result.Value<string>(), item);
            }

            Dictionary<string, JToken> dicold = new Dictionary<string, JToken>();

            foreach (var item in told)
            {
                var result = item.SelectToken("no");

                dicold.Add(result.Value<string>(), item);
            }


            //新增
            HashSet<string> hadd = new HashSet<string>(dicnew.Select(p => p.Key));
            var listadd = hadd.Except(dicold.Select(p => p.Key));

            foreach (var s in listadd)
            {
                ChangeItem item = new ChangeItem
                {
                    ChangeType = ChangeType.Add,
                    ModifiedContent = dicnew[s].ToString()
                };
                entity.Items.Add(item);
            }
            //移除
            HashSet<string> hremove = new HashSet<string>(dicold.Select(p => p.Key));
            var listremove = hremove.Except(dicnew.Select(p => p.Key));
            foreach (var s in listremove)
            {
                ChangeItem item = new ChangeItem
                {
                    ChangeType = ChangeType.Remove,
                    ModifiedContent = dicold[s].ToString()
                };
                entity.Items.Add(item);
            }



            //相等
            foreach (var item in told)
            {

                var sd = item.SelectToken("no");


                if (dicnew.ContainsKey(sd.ToString()))
                {
                    var child1 = item.SelectToken("sonList");
                    var jso = dicnew[sd.ToString()];
                    var child2 = jso.SelectToken("sonList");
                    if (child1 != null)
                    {
                        var temp1 = item.DeepClone();
                        var temp2 = jso.DeepClone();

                        var r1 = JObject.Load(temp1.CreateReader());
                        var r2 = JObject.Load(temp2.CreateReader());
                        r1.Remove("sonList");
                        r2.Remove("sonList");


                        var rr = r1.Root;

                        var diff = new JsonDifferentiator();
                        var result = diff.Differentiate(r1.Root, r2.Root);

                        if (result != null)
                        {
                            var old = diff.list;

                            var diff2 = new JsonDifferentiator();
                            diff2.Differentiate(jso, item);
                            var news = diff2.list;

                            ChangeItem change = new ChangeItem
                            {
                                ChangeType = ChangeType.Modify,
                                OriginalContent = item.ToString(),
                                OriginalKey = old.FirstOrDefault()?.Key,
                                OriginalValue = old.FirstOrDefault()?.Value,
                                ModifiedContent = jso.ToString(),
                                ModifiedKey = news.FirstOrDefault()?.Key,
                                ModifiedValue = news.FirstOrDefault()?.Value
                            };

                            entity.Items.Add(change);
                        }

                        Func(child1, child2);
                    }
                    else
                    {

                        var diff = new JsonDifferentiator();
                        var result = diff.Differentiate(item, jso);
                        if (result != null)
                        {
                            var old = diff.list;

                            var diff2 = new JsonDifferentiator();
                            diff2.Differentiate(jso, item);
                            var news = diff2.list;

                            ChangeItem change = new ChangeItem
                            {
                                ChangeType = ChangeType.Modify,
                                OriginalContent = item.ToString(),
                                OriginalKey = old.FirstOrDefault()?.Key,
                                OriginalValue = old.FirstOrDefault()?.Value,
                                ModifiedContent = jso.ToString(),
                                ModifiedKey = news.FirstOrDefault()?.Key,
                                ModifiedValue = news.FirstOrDefault()?.Value
                            };

                            entity.Items.Add(change);
                        }

                    }
                }
                //if 包含sonList  继续








            }
        }
    }
}
