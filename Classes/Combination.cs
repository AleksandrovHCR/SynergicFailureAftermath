using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<List<Link>> Combine=new List<List<Link>>();//Комбинация
        public Combination(Failure failure)
        {
            foreach(Link link in failure.GetCriticalLinks())
            {
                сombination.Add(link.getIndex());
            }
            Items.Add(failure);
           this.Summ=RecalculateScale();
            UpdateCombine();
            //Summ += failure.GetScaleOfFailure();
        }
        private void UpdateCombine() { 
        Combine.Clear();
            foreach(Failure link in Items)
            {
                Combine.Add(link.GetCriticalLinks());
            }
        }
        public Combination() { }
        public Combination(Combination combination) { 
            Items=combination.Items;
            Summ = combination.Summ;
            UpdateCombine();
            this.Summ=RecalculateScale();
        }

      
        public void Add(Failure failure) {
            foreach (Link link in failure.GetCriticalLinks())
            {
                сombination.Add(link.getIndex());
            }
            Items.Add(failure);
            UpdateCombine();
            this.Summ = RecalculateScale();
            //Summ += failure.GetScaleOfFailure();
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
        private int RecalculateScale()
        {
            int S = 0;
            foreach (Failure failure in Items)
            {
                S += failure.GetConsumers().Count;    
            }
            return S;
        }
        public Result ConvertToResult(int Index)
        {
            int Total_consumers = 0;
            string Critical = null;
            foreach (Failure failure in Items)
            {
                Total_consumers+=failure.GetConsumers().Count;
                Critical += failure.GCL_string()+"; ";
            }

            return new Result(Index,Critical,Total_consumers);
           
        }
        public Combination Copy_and_replace( Combination cmb, Failure failure)
        {
            Combination CMB=new Combination(cmb);
            //foreach(Link link in failure.GetCriticalLinks())
            //{
            //    //foreach(Failure failure1 in cmb.Items)
            //    //{
            //    //    if(failure1.GetCriticalLinks().Contains(link))
            //    //       CMB.Items.Remove(failure1);
            //    //}
            //    for(int i = 0; i < cmb.Items.Count; i++)
            //    {
            //        if (cmb.Items[i].GetCriticalLinks().Contains(link))
            //              CMB.Items.Remove(cmb.Items[i]);
            //    }
            //}
            List<Link> links_for_remove = new List<Link>();
            foreach (Link link in failure.GetCriticalLinks()) { 
                links_for_remove.Add(link);
            }
            List<Failure> ITMS=cmb.Items.ToList();
            foreach (Link link in links_for_remove)
            {
                foreach (Failure f in ITMS)
                {
                    if (f.GetCriticalLinks().Contains(link) && f.GetCriticalLinks().Count == 1)
                    {
                        ITMS.Remove(f); break;
                    }
                }
            }
            CMB.Items = ITMS;
            CMB.Summ = RecalculateScale();
            CMB.Items.Add(failure);
            CMB.UpdateCombine();
            return CMB;

        }

        public bool ItIsFitThere(Failure fail)
        {
            List<Link> tmp = new List<Link>();
            foreach(Failure f in Items)
            {
                if (f.GetCriticalLinks().Count == 1)
                    tmp.Add(f.GetCriticalLinks().First());
            }
            foreach (Link lnk1168 in fail.GetCriticalLinks())
            {
                if(!tmp.Contains(lnk1168))
                    return false;
            }
            if(tmp.Count!=fail.GetCriticalLinks().Count) return false;
            return true;
        }

        public bool IsContainPart(Failure fail)
        {
            if (Items.Contains(fail)) return true; else return false;
        }

        public static bool operator ==(Combination left, Combination right)
        {
            if (left.Items.Count != right.Items.Count) return false;
            else
            {
                int Compared = 0;
                foreach (Failure link in left.Items)
                {
                    if (right.Items.Contains(link)) Compared++;
                }
                if (left.Items.Count == Compared) return true;
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
