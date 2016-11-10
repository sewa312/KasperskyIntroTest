using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyIntroTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection set = new Collection();
            set.Add(2);
            set.Add(1);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(6);
            set.Add(7);
            set.Add(9);
            set.Add(10);
            set.Add(11);
            set.FindAllPairs(20);
            Console.ReadLine();
        }
    }
}
