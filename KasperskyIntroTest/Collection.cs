using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyIntroTest
{
    class Collection
    { 
        private SortedSet<float> set;

        public Collection()
        {
            set = new SortedSet<float>();
        }

        public void Add(float item)
        {
            set.Add(item);
        }

        public void FindAllPairs(float x)
        {
            float[] collect = new float[set.Count];
            set.CopyTo(collect);
            for (int i = 0; i < collect.Length; i++)
            {
                if (set.Contains(x - collect[i]) && collect[i] >= (x - collect[i]))
                    Console.WriteLine("{0} = {1} + {2}", x, x - collect[i], collect[i]);
            }
        } 
    }
}
