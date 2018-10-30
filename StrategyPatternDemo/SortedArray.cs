using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class SortedArray
    {
        private int[] arr = new int[5];
        private int index = 0;
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(int number)
        {
            arr[index] = number;
            index++;
        }

        public void ExecuteSort()
        {
            _sortstrategy.Sort(arr);
            // Iterate over list and display results
            foreach (int number in arr)
            {
                Console.WriteLine(" " + number);
            }
            Console.WriteLine();
        }
    }
}
