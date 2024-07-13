using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath.Classes
{
    public class Result
    {
        private int Index;
        private string Mnojestva;
        private int Scale;
        public Result(int index, string mnojestva, int scale)
        {
            Index = index;
            Mnojestva = mnojestva;
            Scale = scale;
        }
        public int GetScale() { return Scale; }
        public int GetIndex() { return Index; }
        public string GetMnojestva() {return Mnojestva;}
    }
}
