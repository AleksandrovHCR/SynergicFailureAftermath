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
        


        private int N_Links;//Число узлов
        private List<Link> All_Links;//Все узлы
        public Graph() { N_Links = 0; All_Links = new List<Link> { };  }
        public int GetNLinks() => N_Links;
        public int AddLink(Link link) { All_Links.Add(link);N_Links++; return 0;}
    }
}
