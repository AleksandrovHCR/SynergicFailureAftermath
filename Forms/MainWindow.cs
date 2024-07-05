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
            очиститьToolStripMenuItem.Enabled = true;
            Graph_box.Enabled = true;
            InitializeGraph();
            MessageBox.Show("Программа подготовлена к работе.", "Information.",MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartButton.Enabled = false;
            Graph_datagrid.ReadOnly = true;
            LinkManager.Enabled = true;
        }

        private void LinkManager_Click(object sender, EventArgs e)
        {
            LinkManager linkManager = new LinkManager(Main_Graph,this);
            linkManager.ShowDialog();
        }
    }
}
