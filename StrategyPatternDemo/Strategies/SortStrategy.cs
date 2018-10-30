using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    abstract class SortStrategy

    {
        public abstract void Sort(int[] arr);
    }
}
