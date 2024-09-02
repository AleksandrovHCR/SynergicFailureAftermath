
using System.Collections.Generic;


namespace SynergicFailureAftermath.Classes
{
    public class Failure
    {
        private int Index;
        private List<Link> ScaleOfFailure;//Вышедшие из строя узлы
        private bool IsTotal = false;
        private List<Link> RandomCrits = new List<Link>();
        private HashSet<int> Subset=new HashSet<int>();

        public Failure(int index, List<Link> scaleOfFalure, bool IsTotal)
        {
            Index = index;
            ScaleOfFailure = scaleOfFalure;
            this.IsTotal = IsTotal;
            RandomCrits = GetCriticalLinks();
        }
        public Failure(int index, List<Link> scaleOfFalure, bool IsTotal, HashSet<int> Subset)
        {
            Index = index;
            this.Subset=Subset;
            ScaleOfFailure = scaleOfFalure;
            this.IsTotal = IsTotal;
            RandomCrits = GetCriticalLinks();
        }

        public List<Link> GetCriticalLinks()
        { 
            List<Link> temp = new List<Link>();
            if (Subset.Count == 0)
            {
               // List<Link> temp = new List<Link>();
                foreach (Link link in ScaleOfFailure)
                {
                    if (link.GetLinkType() == 4)
                        temp.Add(link);
                }
            }
            else
            {
               
                foreach (Link link in ScaleOfFailure)
                {
                    if (link.GetLinkType() == 4 && Subset.Contains(link.getIndex()))
                        temp.Add(link);
                }
            }
            return temp;
        }
        public bool IsTotalFailure()=>IsTotal;
        public List<Link> GetConsumers()
        {
            List<Link> temp = new List<Link>();
            foreach (Link link in ScaleOfFailure)
            {
                if (link.GetLinkType() == 3)
                    temp.Add(link);
            }
            return temp;
        }
        public int GetIndex() =>Index;
        public int GetScaleOfFailure()
        {
            int summ = 0;
            foreach (Link link in ScaleOfFailure)
            {
                if(link.GetLinkType()==3)
                    summ++;
            }
            return summ;
        }
        public List<Link> GetScaleOfFailureList() => ScaleOfFailure;
        public Link GetBreaked(int Index) => ScaleOfFailure[Index];

        public string GCL_string()
        {
            string temp = null;
            foreach (Link link in ScaleOfFailure)
            {
                if (link.GetLinkType()==4 && Subset.Contains(link.getIndex()))
                temp += $"{link.getIndex() + 1};";
            }
            return '{' + temp + '}';
        }

    }
}
