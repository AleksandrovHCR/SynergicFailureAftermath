using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath.Classes
{
    public class P_Link
    {
        protected enum Link_type { DEFAULT, SOURCE, CONSUMER, CRITICAL }
        //protected enum state { WORKING, BROKEN}
        protected enum Instance { WORKING, DISABLED, BROKEN, NOTCONNECTED}
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
        //protected state setState(int IDState)
        //{
        //    switch(IDState)
        //    {
        //        case 0: return state.BROKEN;
        //        default: return state.WORKING;
        //    }
        //}
        protected int Index;


        protected Instance SetInstance(int  IDType) {
            switch (IDType)
            {
                case 1: return Instance.WORKING;
                case 2: return Instance.DISABLED;
                case 3: return Instance.BROKEN;
                case 4: return Instance.NOTCONNECTED;   
                default: return Instance.WORKING;
            }
        }
        
    }
}
