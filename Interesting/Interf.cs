using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    public interface Interf
    {
        string Field { get; set; }

        event SampleEventHandler SampleEvent;

        //virtual void Virtual(); -- virtual not valid
        //string A; --cannot contains fields        
    }





    public class SampleEventArgs
    { }

    public delegate void SampleEventHandler(object sender, SampleEventArgs e);
}
