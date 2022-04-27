using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCounter.Model
{
    public class Model
    {
        public int CounterValue;
        public byte CounterSize;
        public byte R, G, B;

        public Model(int counterValue, byte counterSize , byte r, byte g, byte b)
        {
            CounterValue = counterValue;
            CounterSize = counterSize;
            R = r;
            G = g;
            B = b;
        }

        public void Add()
        {
            CounterValue++;
        }

        public void Sub()
        {
            CounterValue--;
        }

        public void Reset()
        {
            CounterValue=0;
        }
    }
}
