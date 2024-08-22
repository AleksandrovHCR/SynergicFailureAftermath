using System.Collections.Generic;
using System.ComponentModel;
namespace SynergicFailureAftermath.Database
{
    public class Subset
    {
        public int Index;
        public HashSet<int> Items;
        public Subset(int Index, HashSet<int> Items) { this.Index = Index; this.Items = Items; }

    }
}
