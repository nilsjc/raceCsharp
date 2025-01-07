using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raceLab
{
    public class SortedData(string key, int data)
    {
        public List<int> Data { get; set; } = [data];
        public string Key { get; } = key;
        public int Numbers { get; set; } = 1;
    }
}