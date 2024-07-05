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
        


        //private int N_Links;//Число узлов
        private List<Link> All_Links;//Все узлы
        public Graph() {  All_Links = new List<Link> { };  }
        public int GetNLinks() => All_Links.Count;
        public int AddLink(Link link) { All_Links.Add(link); return 0;}
        public Link GetLink(int Index)=> All_Links[Index];
        
    }
}
