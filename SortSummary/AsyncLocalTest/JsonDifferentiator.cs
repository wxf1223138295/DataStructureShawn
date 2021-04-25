using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace AsyncLocalTest
{
    public enum ChangeType
    {
        Add,
        Remove,
        Modify
    }
    public class AllDifferentItemsResponse
    {
        public AllDifferentItemsResponse()
        {
            Items = new List<ChangeItem>();
        }
        public List<ChangeItem> Items { get; set; }
    }

    public class ChangeItem
    {
        public ChangeType ChangeType { get; set; }

        public string OriginalContent { get; set; }
        public string OriginalKey { get; set; }
        public string OriginalValue { get; set; }
        public string ModifiedContent { get; set; }
        public string ModifiedKey { get; set; }
        public string ModifiedValue { get; set; }
    }

    public class JsonEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class JsonDifferentiator
    {
        public List<JsonEntity> list=new List<JsonEntity>();

        public JToken Differentiate(JToken first, JToken second)
        {
            if (JToken.DeepEquals(first, second)) return null;

            if (first != null && second != null && first?.GetType() != second?.GetType())
                throw new InvalidOperationException($"Operands' types must match; '{first.GetType().Name}' <> '{second.GetType().Name}'");

            var propertyNames = (first?.Children() ?? default).Union(second?.Children() ?? default)?.Select(_ => (_ as JProperty)?.Name)?.Distinct();

            if (!propertyNames.Any() && (first is JValue || second is JValue))
            {
                return (first == null) ? second : first;
            }

            var difference = JToken.Parse("{}");

            foreach (var property in propertyNames)
            {
                if (property == null)
                {
                    if (first == null)
                    {
                        difference = second;
                    }
                    // array of object?
                    else if (first is JArray && first.Children().All(c => !(c is JValue)))
                    {
                        var difrences = new JArray();
                        //var mode = second == null ? '-' : '*';
                        var maximum = Math.Max(first?.Count() ?? 0, second?.Count() ?? 0);

                        for (int i = 0; i < maximum; i++)
                        {
                            var firstsItem = first?.ElementAtOrDefault(i);
                            var secondsItem = second?.ElementAtOrDefault(i);

                            var diff = Differentiate(firstsItem, secondsItem);

                            if (diff != null)
                            {
                                difrences.Add(diff);
                            }
                        }

                        if (difrences.HasValues)
                        {
                            difference/*[$"{mode}{property}"] */= difrences;
                        }
                    }
                    else
                    {
                        difference = first;
                    }

                    continue;
                }

                if (first?[property] == null)
                {
                    var secondVal = second?[property]?.Parent as JProperty;

                    difference[$"+{property}"] = secondVal.Value;
                    continue;
                }

                if (second?[property] == null)
                {
                    var firstVal = first?[property]?.Parent as JProperty;

                    difference[$"-{property}"] = firstVal.Value;
                    continue;
                }

                if (first?[property] is JValue value)

                {
                    if (!JToken.DeepEquals(first?[property], second?[property]))
                    {
                        difference[$"*{property}"] = value;
                       
                    }

                    continue;
                }

                if (first?[property] is JObject)
                {
                    var mode = second?[property] == null ? '-' : '*';
                    var firstsItem = first[property];
                    var secondsItem = second[property];

                   
                    var diffrence = Differentiate(firstsItem, secondsItem);

                    if (diffrence != null /*&& diffrence.Count() > 0*/)
                    {
                        difference[$"{mode}{property}"] = diffrence;
                    }

                    continue;
                }

                if (first?[property] is JArray)
                {
                    var difrences = new JArray();
                    var mode = second?[property] == null ? '-' : '*';
                    var maximum = Math.Max(first?[property]?.Count() ?? 0, second?[property]?.Count() ?? 0);

                    for (int i = 0; i < maximum; i++)
                    {
                        var firstsItem = first[property]?.ElementAtOrDefault(i);
                        var secondsItem = second[property]?.ElementAtOrDefault(i);

                       
                        var diff = Differentiate(firstsItem, secondsItem);

                        if (diff != null)
                        {
                            var valueStr=diff?.First?.First?.Value<string>();
                            var len = diff?.First?.Path.Length;
                            if (len > 0)
                            {
                                var keyStr=diff?.First?.Path.Substring(1, Convert.ToInt32(len) - 1);
                                list.Add(new JsonEntity
                                {
                                    Key = keyStr,
                                    Value = valueStr
                                });
                            }

                            difrences.Add(diff);
                        }
                    }

                    if (difrences.HasValues)
                    {
                        difference[$"{mode}{property}"] = difrences;
                    }

                    continue;
                }
            }

            return difference;
        }
    }
}
