using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo.Strategies
{
    class QuickSort : SortStrategy

    {
        public override void Sort(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("QuickSorted list ");
        }
    }
}
