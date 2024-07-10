using SynergicFailureAftermath.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath.Classes
{
    public class Graph
    {
        private List<Link> All_Links;//Все узлы
      

        public Graph() {  All_Links = new List<Link> { }; }
        public int GetNLinks() => All_Links.Count;
        public int AddLink(Link link) { All_Links.Add(link); return 0;}
        public Link GetLink(int Index)=> All_Links[Index];

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
            foreach (Link link in All_Links)
            {
                if (link.GetLinkInstance() == 1)
                    link.ProvideEnergy();
            }
        }

        
    }
}
