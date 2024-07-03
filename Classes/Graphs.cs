using SynergicFailureAftermath.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath.Classes
{
    internal class Graphs
    {
        private int N_Links = 0;//Число узлов
        private List<Link> All_Links = null;//Все узлы
        public Graphs() { }
        public int AddLink(Link link) { All_Links.Add(link);N_Links++; return 0;}
    }
}
