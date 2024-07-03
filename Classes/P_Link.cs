using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergicFailureAftermath.Classes
{
    internal class P_Link
    {
        protected enum Link_type { DEFAULT, SOURCE, CONSUMER, CRITICAL }
        protected enum state { WORKING, BROKEN}
        protected Link_type setType(int IDType) {
            switch (IDType)
            {
                case 1: return Link_type.DEFAULT;
                case 2: return Link_type.SOURCE;
                case 3: return Link_type.CONSUMER;
                case 4: return Link_type.CRITICAL;
                default: return Link_type.DEFAULT;
            }
        }  
        protected state setState(int IDState)
        {
            switch(IDState)
            {
                case 0: return state.BROKEN;
                default: return state.WORKING;
            }
        }
        protected int Index { get { return Index; } set { Index = value; } }
    }
}
