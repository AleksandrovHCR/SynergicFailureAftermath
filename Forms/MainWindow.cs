using SynergicFailureAftermath.Forms;
using SynergicFailureAftermath.Classes;
using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.IO;


namespace SynergicFailureAftermath
{
   
      
    public partial class MainWindow : Form
    {

        //private delegate void WindowLiveReaction();

        private void DataGridUpd()//To do. Доработать
        {
            Graph_datagrid.ColumnCount = Main_Graph.GetNLinks()+1;
            Graph_datagrid.RowCount = Main_Graph.GetNLinks();
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
            удалитьузелToolStripMenuItem.Enabled=true;
            выходToolStripMenuItem.Enabled = true;
            загрузитьГрафToolStripMenuItem.Enabled=true;
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
        
        private void удалитьузелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph_datagrid.Rows.Clear();
            Graph_datagrid.Columns.Clear();
            StartButton.Enabled = true;
            Graph_datagrid.ReadOnly = true;
            добавитьУзелToolStripMenuItem.Enabled = false;
            LinkManager.Enabled = false;
            ModellingButton.Enabled = false;
            удалитьузелToolStripMenuItem.Enabled = false;
            выходToolStripMenuItem.Enabled = false;
            загрузитьГрафToolStripMenuItem.Enabled = false;
            MessageBox.Show("Граф удалён.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Graph *G=new Graph();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)//Запись графа в файл
        {
            if (Main_Graph.GetNLinks() == 0)
            {
                MessageBox.Show("Граф пуст.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                Savefile = new SaveFileDialog();
                Savefile.Filter= "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                Savefile.FilterIndex = 1; 
                if (Savefile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter AC = new StreamWriter(Savefile.FileName);
                    Main_Graph.RecordFileToWindows(AC);
                }
                }
            
        }

        private void загрузитьГрафToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile=new OpenFileDialog();
            OpenFile.Filter= "txt files (*.txt)|*.txt";
            OpenFile.FilterIndex = 1;
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                if (OpenFile.FileName != null)
                {
                    Main_Graph=new Graph();
                    Graph_datagrid.Rows.Clear();
                    Graph_datagrid.Columns.Clear();
                    StreamReader SM = new StreamReader(OpenFile.FileName);
                    Main_Graph.ReadFileFromWindows(SM,this);
                   // DataGridUpd();
                  //  AddLink AddLinkForm = new AddLink(Main_Graph, this);
                 //   AddLinkForm.DataGridUpd();
                }
            }
        }
    }
}
