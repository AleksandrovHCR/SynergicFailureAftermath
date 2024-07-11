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

namespace SynergicFailureAftermath.Forms
{
    public partial class Modelling : Form
    {
        private Graph Graph;

        private delegate void PowerPlant();
        private PowerPlant _powerPlant;
        //private PowerPlant _disablePower;

        private void EnableSources()
        {
            for (int i = 0; i < Graph.GetNLinks(); i++)
            {
                if (Graph.GetLink(i).GetLinkType() == 2)
                {
                    Graph.GetLink(i).SetLinkInstance(1);
                    Graph.GetLink(i).ProvideEnergy();
                }
            }
        }

      private void UpdateCLinkLists()
        {
            Critical_working.Items.Clear();
            Critical_broken.Items.Clear();
            for (int i = 0; i < Graph.GetNLinks(); i++)
            {
                if (Graph.GetLink(i).GetLinkType() == 4 && Graph.GetLink(i).GetLinkInstance()!=3)
                {
                    Critical_working.Items.Add($"{Graph.GetLink(i).getIndex() + 1}");
                }
            }
            for (int i = 0; i < Graph.GetNLinks(); i++)
            {
                if (Graph.GetLink(i).GetLinkType() == 4 && Graph.GetLink(i).GetLinkInstance() == 3)
                {
                    Critical_broken.Items.Add($"{Graph.GetLink(i).getIndex() + 1}");
                }
            }
        }

        private void UpdateDatagrid()
        {
            LinksInstanceGrid.Rows.Clear();
            for(int i = 0; i < Graph.GetNLinks(); i++)
            {
                
                LinksInstanceGrid.Rows.Add();
                LinksInstanceGrid[0,i].Value= Graph.GetLink(i).getIndex() + 1;
                switch (Graph.GetLink(i).GetLinkType())
                {
                    case 1: LinksInstanceGrid[1, i].Value = "Обычный"; break;
                    case 2: LinksInstanceGrid[1, i].Value = "Источник"; break;
                    case 3: LinksInstanceGrid[1, i].Value = "Потребитель"; break;
                    case 4: LinksInstanceGrid[1, i].Value = "Критический"; break;
                }
                switch (Graph.GetLink(i).GetLinkInstance())
                {
                    case 1: LinksInstanceGrid[2, i].Value = "Работает"; break;
                    case 2: LinksInstanceGrid[2, i].Value = "Отключен"; break;
                    case 3: LinksInstanceGrid[2, i].Value = "Сломан"; break;
              
                }
            }
        }
        public Modelling(Graph Graph)
        {
            InitializeComponent();
            this.Graph = Graph;
            UpdateDatagrid();
            
            SourceList.Rows.Clear();
            for (int i = 0;i<Graph.GetNLinks();i++) {
                if (Graph.GetLink(i).GetLinkType() == 2)
                {
                    
                    SourceList.Rows.Add();
                    SourceList[0, SourceList.Rows.Count - 2].Value = Graph.GetLink(i).getIndex() + 1;

                    string message = null;
                    for (int j = 0; j < Graph.GetLink(i).GetLinks(); j++)
                    {
                        message += $"{Graph.GetLink(i).GetConnectedLink(j).getIndex() + 1};";
                    }
                    SourceList[1, SourceList.Rows.Count - 2].Value = message;
                }
            }
            _powerPlant += EnableSources;
            _powerPlant += Graph.Energize;
            _powerPlant += UpdateDatagrid;
            UpdateCLinkLists();
           
        }

        private void StartModelling_Click(object sender, EventArgs e)
        {
            _powerPlant.Invoke();
        }

        private void CancelModelling_Click(object sender, EventArgs e)
        {
            for(int i=0;i< Graph.GetNLinks();i++)
            {
                
                Graph.GetLink(i).SetLinkInstance(2);
            }
            UpdateDatagrid();
            UpdateCLinkLists();
        }

        private void BreakLink_Click(object sender, EventArgs e)
        {
            if(Critical_working.SelectedItem!=null)
           Graph.GetLink(Int32.Parse(Critical_working.SelectedItem.ToString()) - 1).SetLinkInstance(3);
            UpdateCLinkLists();
        }

        private void RepairLink_Click(object sender, EventArgs e)
        {
            if (Critical_broken.SelectedItem != null)
                Graph.GetLink(Int32.Parse(Critical_broken.SelectedItem.ToString()) - 1).SetLinkInstance(2);
            UpdateCLinkLists();
        }
    }
}
