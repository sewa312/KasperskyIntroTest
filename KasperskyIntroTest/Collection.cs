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
            foreach (var element in set)
            {
                if (element > x / 2) { break; }
                if (set.Contains(x - element))
                    Console.WriteLine("{0} = {1} + {2}", x, x - element, element);
                
            }
        } 
    }
}
