using SynergicFailureAftermath.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynergicFailureAftermath
{
    public partial class LinkManager : Form
    {
        public Graph Graph;//График
        private delegate void LiveReaction(Link Link);
        private event LiveReaction LinkManagerLiveReactrion;

        private void ShowAllConnectedLinks(Link Link)//Связанные узлы
        {
            Connected_links.Items.Clear();
            if (Link.GetLinks() != 0)
            {
                for (int i = 0;i< Link.GetLinks(); i++)
                {
                    Connected_links.Items.Add(Link.GetConnectedLink(i));
                }
            }
            
        }
        private void ShowLinkType(Link Link)//Выбранный тип
        {
                RB_Default.Checked = false; 
                RB_Source.Checked = false;
                RB_Consumer.Checked = false; 
                RB_Critical.Checked = false;
                switch (Link.GetLinkType())
                {
                case 1: RB_Default.Checked=true; break;
                case 2: RB_Source.Checked = true; break;
                case 3: RB_Consumer.Checked = true; break;
                case 4: RB_Critical.Checked = true; break;
                }
        }
        private void ShowAvaliableLinks(Link Link)
        {
            Avaliable_to_connect.Items.Clear();
            if(Graph.GetNLinks() != 0)
            {
                for(int i = 0;i< Graph.GetNLinks(); i++)
                {
                    Avaliable_to_connect.Items.Add(Graph.GetLink(i).getIndex()+1);
                }
            }
        }


        public LinkManager(Graph GRPH1, MainWindow MW)
        {
            InitializeComponent();
            Graph = GRPH1;
            for(int i = 0; i<Graph.GetNLinks();i++)
                LinksCombo.Items.Add($"{i+1}");
            LinkManagerLiveReactrion += ShowLinkType;
            LinkManagerLiveReactrion += ShowAllConnectedLinks;
            LinkManagerLiveReactrion += ShowAvaliableLinks;
        }

        private void LinksCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (LinksCombo.SelectedIndex != -1)
            {
                LinkManagerLiveReactrion.Invoke(Graph.GetLink(LinksCombo.SelectedIndex));
            }
        }

        private void ChangeTypeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
