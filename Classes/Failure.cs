using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath.Classes
{
    public class Failure
    {
        private int Index;
        private List<Link> ScaleOfFailure;//Вышедшие из строя узлы

        public Failure(int index, List<Link> scaleOfFalure)
        {
            Index = index;
            ScaleOfFailure = scaleOfFalure;
        }
        
        public List<Link> GetCriticalLinks()
        {
            List<Link> temp = new List<Link>();
            foreach (Link link in ScaleOfFailure)
            {
                if (link.GetLinkType()==4)
                    temp.Add(link);
            }
            return temp;
        }
        public int GetIndex() =>Index;
        public int GetScaleOfFailure() =>ScaleOfFailure.Count;
        public Link GetBreaked(int Index) => ScaleOfFailure[Index];


    }
}
