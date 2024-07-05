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
        private Link_type _type; //Тип
        //private int Links=0;//Число связанных узлов
        private List<Link> Connected_Links;//Связанные узлы
        private Instance _instance; //Состояние
        public int getIndex() => Index; 
        public int GetLinks() => Connected_Links.Count;
        public Link(int Index,int IDType) { this.Index = Index;_type = setType(IDType);Connected_Links = new List<Link> { }; }//Добавить узел
        public int GetLinkType()
        {
            if (_type == Link_type.DEFAULT) return 1;
            if (_type == Link_type.SOURCE) return 2;
            if (_type == Link_type.CONSUMER) return 3;
            if (_type == Link_type.CRITICAL) return 4;
            else return 0;
        }
        public int AddConnectedLink(Link AddLink) { Connected_Links.Add(AddLink); return 0; } //Добавить соединение
        public Link GetConnectedLink(int Index) => Connected_Links[Index];
        public void changeType(int Index) { _type=setType(Index); }
        //public List<Link> GetConnectedLinks() => Connected_Links;
       
    }
}
