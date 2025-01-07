using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace raceLab
{
    public static class DataHandlers
    {
        static ConcurrentBag<SortedData> sortedData = new ConcurrentBag<SortedData>();
        public static void Sort(ReturnObject ret)
        {
                var lst = sortedData.FirstOrDefault(x => x.Key == ret.Id);
                if (lst is null)
                {
                    sortedData.Add(new SortedData(ret.Id, ret.Value));
                }
                else
                {
                    lst.Data.Add(ret.Value);
                    lst.Numbers++;
                }
        }
        public static void Analyze()
        {
            Console.WriteLine("Analyze sorteddata");
            Console.WriteLine("Count each group of data. Should be the same numbers");
            var groups = sortedData.GroupBy(x => x.Key);
            foreach(var group in groups)
            {
                foreach(var ent in group)
                {
                    Console.Write($"{ent.Data.Count}, ");
                }
            }
        }
    }
}