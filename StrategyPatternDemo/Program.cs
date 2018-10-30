using StrategyPatternDemo.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedArray studentRecords = new SortedArray();

            studentRecords.Add(56);
            studentRecords.Add(68);
            studentRecords.Add(96);
            studentRecords.Add(4);
            studentRecords.Add(25);

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.ExecuteSort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.ExecuteSort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.ExecuteSort();

            // Wait for user
            Console.ReadKey();
        }
    }
}
