using SynergicFailureAftermath.Forms;
using SynergicFailureAftermath.Classes;
using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;


namespace SynergicFailureAftermath
{
   
      
    public partial class MainWindow : Form
    {

        //private delegate void WindowLiveReaction();

        private void DataGridUpd()
        {
            for (int i = 1; i < Graph_datagrid.Columns.Count; i++)
            {
                Link G = Main_Graph.GetLink(i - 1);
                for (int j = 0; j < Graph_datagrid.Columns.Count; j++)
                {
                    if (i - 1 != j)
                    {

                        if (G.FindConnectedLink(j))
                        {
                            Graph_datagrid[i, j].Value = "+";
                        }
                        else
                        {
                            Graph_datagrid[i, j].Value = " ";
                        }
                    }
                }
            }

        }


        private Graph Main_Graph { get; set; }
        public void InitializeGraph()
        {
            Main_Graph = new Graph();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        
        private void добавитьУзелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddLink AddLinkForm=new AddLink(Main_Graph, this);
            AddLinkForm.Owner = this;
            AddLinkForm.ShowDialog();
           
        }

        

        private void StartButton_Click(object sender, EventArgs e)
        {
            добавитьУзелToolStripMenuItem.Enabled = true;
           // удалитьузелToolStripMenuItem.Enabled = true;
            Graph_box.Enabled = true;
            InitializeGraph();
            MessageBox.Show("Программа подготовлена к работе", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartButton.Enabled = false;
            Graph_datagrid.ReadOnly = true;
            LinkManager.Enabled = true;
            ModellingButton.Enabled = true;
        }

        private void LinkManager_Click(object sender, EventArgs e)
        {
            LinkManager linkManager = new LinkManager(Main_Graph,this);
            linkManager.ShowDialog();
        }

        private void ModellingButton_Click(object sender, EventArgs e)
        {
            Modelling modelling=new Modelling(Main_Graph);
            modelling.ShowDialog();
        }
        
        private void удалитьузелToolStripMenuItem_Click(object sender, EventArgs e)//To do. Починить
        {
            if(Main_Graph.GetNLinks() > 0)
            {
                Main_Graph.RemoveLink(Main_Graph.GetNLinks());
            }
           DataGridUpd();
        }
    }
}
