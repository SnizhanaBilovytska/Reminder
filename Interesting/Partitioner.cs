using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    // If you have a lot of very small tasks to run in parallel the overhead of invoking delegates for each may be prohibitive. 
    //By using Partitioner, you can rearrange the workload into chunks and have each parallel invocation work on a slightly larger set. 
    //Партицирование - разделение
    class PartitionerEx
    {
        public static void Example()
        {
            int[] source = { 1, 2 };

            var rangePartitioner = Partitioner.Create(0, source.Length);
            Parallel.ForEach(rangePartitioner, (range, loopState) =>
            {
                // Loop over each range element without a delegate invocation.
                int startIndex = range.Item1;
                int endIndex = range.Item2;
                for (int i = startIndex; i < endIndex; i++)
                {
                    var item = source[i];
                    //Do work on item
                    Console.WriteLine(item);
                }
            });
        }
    }
}
