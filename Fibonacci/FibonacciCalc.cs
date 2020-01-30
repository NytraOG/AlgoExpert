using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciCalc
    {
        public int GetNthFib(int n)
        {
            var zwischenSpeicher = new int[n];

            for (int i = 0; i < n; i++)
            {
                switch (i) {
                    case 0: zwischenSpeicher[0] = 0;
                        break;
                    case 1: zwischenSpeicher[1] = 1;
                        break;
                    default : zwischenSpeicher[i] = zwischenSpeicher[i - 1] + zwischenSpeicher[i - 2];
                        break;
                }
            }

            var retVal = zwischenSpeicher[n - 1];

            return retVal;
        }
    }
}
