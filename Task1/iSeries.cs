using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ISeries
    {
        void SetStart(long x);
        long GetNext();
        long GetPrevious();
        void Reset();

    }
    class ArithProgression : ISeries
    {
        long step;
        long startValue;
        long currentValue;
        public long GetNext()
        {
            currentValue += step;
            return currentValue;    
        }
        public long GetPrevious()
        {
            currentValue -= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(long x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(long y)
        {
            step = y;
        }

    }

    class GeomProgression : ISeries
    {
        long step;
        long startValue;
        long currentValue;
        public long GetNext()
        {
            currentValue *= step;
            return currentValue;
        }
        public long GetPrevious()
        {
            currentValue /= step;
            if (currentValue < startValue) currentValue = startValue;
            return currentValue;
        }
        public void Reset()
        {
            currentValue = startValue; 
        }

        public void SetStart(long x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(long y)
        {
            step = y;
        }

    }
}
