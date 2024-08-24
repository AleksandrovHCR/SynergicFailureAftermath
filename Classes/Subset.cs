using System.Collections.Generic;

namespace SynergicFailureAftermath.Classes
{
    public class Subset
    {
        private int Index;
        private HashSet<int> Items;
        public Subset(int Index, HashSet<int> Items) { this.Index = Index;this.Items = Items; }
        public int GetIndex() { return Index; }
        public HashSet<int> GetItems() {  return Items; }
        
    }
}
