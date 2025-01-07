using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raceLab
{
    public class DataGenerator(string name, int numbers)
    {
        private readonly int _numbers = numbers;
        private readonly string _name = name;
        private int _count = 0;
        public IEnumerable<ReturnObject> GetSingleObject()
        {
            for(int x = 0; x < _numbers; x++)
            {
                yield return new ReturnObject
                {
                    Id = _name,
                    Value = _count++
                };
            }
        }
    }
}