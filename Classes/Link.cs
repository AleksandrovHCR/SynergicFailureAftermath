using SynergicFailureAftermath.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynergicFailureAftermath
{
    public class Link:P_Link
    {
        private Link_type _type;
        private int Links=0;//Число связанных узлов
        private List<Link> Connected_Links;//Связанные узлы
        private Instance _instance;
        public int getIndex() { return Index; }
        public int GetLinks() => Links;
        public Link(int Index,int IDType) { this.Index = Index;_type = setType(IDType);Connected_Links = new List<Link> { }; }//Добавить узел
       
        public int AddConnectedLink(Link AddLink) { Connected_Links.Add(AddLink); Links++; return 0; }

       
    }
}
