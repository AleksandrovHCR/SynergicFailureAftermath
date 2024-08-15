using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynergicFailureAftermath.Classes;

namespace SynergicFailureAftermath.Forms
{
    public partial class LinkViewer : Form
    {
       
        public LinkViewer(Graph Graph)
        {
            InitializeComponent();

            //Инициализация таблицы

            for (int i = 0; i < Graph.GetNLinks(); i++)
            {
                theListofLinks.Rows.Add();
                theListofLinks[0, i].Value = Graph.GetLink(i).getIndex() + 1;
                switch (Graph.GetLink(i).GetLinkType())
                {
                    case 1: theListofLinks[1, i].Value = "Обычный"; break;
                    case 2: theListofLinks[1, i].Value = "Источник"; break;
                    case 3: theListofLinks[1, i].Value = "Потребитель"; break;
                    case 4: theListofLinks[1, i].Value = "Критический"; break;
                }
                string message = null;
                for(int j=0;j<Graph.GetLink(i).GetLinks();j++) 
                {
                    message += $"{Graph.GetLink(i).GetConnectedLink(j).getIndex()+1};";
                }
                theListofLinks[2, i].Value = message;
            }
        }

        private void LinkViewer_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
