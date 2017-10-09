using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApplication1.Collections
{
    class BlockingCollection
    {
        public static void Example()
        {
            BlockingCollection<int> dataItems = new BlockingCollection<int>(100);

            dataItems.Add(1);
            dataItems.CompleteAdding();
            
            Task.Run(() =>
            {
                while (!dataItems.IsCompleted)
                {                    
                    int data = 0;
                   
                    try
                    {
                        data = dataItems.Take();   // если бы мы не вызвали dataItems.CompleteAdding(); мы бы застряли на этом шаге                   
                    }
                    catch (InvalidOperationException){ }                  
                }
                Console.WriteLine("\r\nNo more items to take.");
            });
        }
    }
}