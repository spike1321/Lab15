using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class GeomProgression : ISeries
    {
        private int start;
        private int res;
        private int step;
        public GeomProgression(int start_, int step_)
        {
            start = start_;
            step = step_;
            res = start_;
        }

        public int GetNext()
        {
            int result = res;
            res *= step;
            return result;
            
        }

        public void Reset()
        {
            res = start;
        }

        public void SetStart(int x)
        {
            start = x;
            res = x;
        }
    }
}
