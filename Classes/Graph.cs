using SynergicFailureAftermath.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace SynergicFailureAftermath.Classes
{
    public class Graph
    {
        private List<Link> All_Links;//Все узлы
      

        public Graph() {  All_Links = new List<Link> { }; }
        public int GetNLinks() => All_Links.Count;
        public int AddLink(Link link) { All_Links.Add(link); return 0;}
        public Link GetLink(int Index)=> All_Links[Index];
        public void RemoveLink(int Index) {  All_Links.RemoveAt(Index); }



        public bool GraphCheck()
        {
            foreach(Link link in All_Links)
            {
                if(link.GetLinkInstance()==2)
                    return false;
            }
            return true;
        }

        public void Energize()//Запуск графа
        {
            
                //foreach (Link link in All_Links)
                //{
                //    if (link.GetLinkInstance() == 1 )
                //        link.ProvideEnergy();
                //}
                
                //foreach (Link link in All_Links)
                //{
                //    if (link.GetLinkInstance() == 3)
                //        link.DisableBranch();
                //}
            for(int i = 0; i < All_Links.Count; i++)
            {
                if (All_Links[i].GetLinkInstance()==1 || All_Links[i].CheckConnectedLinks())
                    All_Links[i].ProvideEnergy();
            }
            foreach (Link link in All_Links)
                {
                    if (link.GetLinkInstance() == 3 || link.CheckBrokenLinks())
                        link.DisableBranch();
                }    
        }


    }
}
