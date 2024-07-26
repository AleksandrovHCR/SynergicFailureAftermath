using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath.Classes
{
    public class Combination
    {
        private List<Failure> Items=new List<Failure>();//Основная комбинация
        private List<int> сombination=new List<int>();//Комбинация, как она есть
        private int Summ = 0;
        public Combination(Failure failure)
        {
            foreach(Link link in failure.GetCriticalLinks())
            {
                сombination.Add(link.getIndex());
            }
            Items.Add(failure);
            Summ += failure.GetScaleOfFailure();
        }
        public Combination() { }
        public Combination(Combination combination) { 
            Items=combination.Items;
            Summ = combination.Summ;
        }

      
        public void Add(Failure failure) {
            foreach (Link link in failure.GetCriticalLinks())
            {
                сombination.Add(link.getIndex());
            }
            Items.Add(failure);
            Summ += failure.GetScaleOfFailure();
        }
        public int getLength(){
            int Summ = 0;
            foreach(Failure link in Items)
            {
                Summ += link.GetCriticalLinks().Count;
            }
            return Summ;
        }
        //public List<int> GetItems()=>Items;

        public Combination Copy_and_replace(Combination cmb, Failure failure)
        {
            Combination CMB=new Combination(cmb);
            foreach(Link link in failure.GetCriticalLinks())
            {
                //foreach(Failure failure1 in cmb.Items)
                //{
                //    if(failure1.GetCriticalLinks().Contains(link))
                //       CMB.Items.Remove(failure1);
                //}
                for(int i = 0; i < cmb.Items.Count; i++)
                {
                    if (cmb.Items[i].GetCriticalLinks().Contains(link))
                          CMB.Items.Remove(cmb.Items[i]);
                }
            }

            CMB.Items.Add(failure);
            return CMB;

        }
        public bool IsContainPart(Failure fail)
        {
            if (Items.Contains(fail)) return true; else return false;
        }

        public static bool operator ==(Combination left, Combination right)
        {
            if(left.Items.Count != right.Items.Count) return false;
            else
            {
                int Compared = 0;
                foreach (Failure link in left.Items)
                {
                    if (right.Items.Contains(link)) Compared++;
                }
                if(left.Items.Count == Compared) return true;
            }
            return false;
        }
        public static bool operator !=(Combination left, Combination right)
        {
            if (left.Items.Count != right.Items.Count) return true;
            else
            {
                int Compared = 0;
                foreach (Failure link in left.Items)
                {
                    if (right.Items.Contains(link)) Compared++;
                }
                if (left.Items.Count == Compared) return false;
            }
           
            return true;
        }
    }
}
