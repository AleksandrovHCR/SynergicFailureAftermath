using SynergicFailureAftermath.Classes;
using SynergicFailureAftermath.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SynergicFailureAftermath
{
    public partial class LinkManager : Form
    {
        public Graph Graph;//График
        private MainWindow MainWindow;//для настройки таблицы
        private delegate void LiveReaction(Link Link);
        private event LiveReaction LinkManagerLiveReaction;


        private void DataGridUpd()
        {
            for(int i=1;i<MainWindow.Graph_datagrid.Columns.Count;i++)
            { 
                Link G = Graph.GetLink(i-1);
                for (int j = 0; j < MainWindow.Graph_datagrid.Columns.Count; j++)
                {
                    if (i - 1 != j)
                    {

                        if (G.FindConnectedLink(j))
                        {
                            MainWindow.Graph_datagrid[i, j].Value = "+";
                        }
                        else
                        {
                            MainWindow.Graph_datagrid[i, j].Value = " ";
                        }
                    }
                }
            }
            
        }



        private void ShowAllConnectedLinks(Link Link)//Связанные узлы
        {
            Connected_links.Items.Clear();
            if (Link.GetLinks() != 0)
            {
                for (int i = 0;i<Link.GetLinks(); i++)
                {
                    //Connected_links.Items.Add(Graph.GetLink(i).GetConnectedLink(i).getIndex()+1);
                    Connected_links.Items.Add(Link.GetConnectedLink(i).getIndex() + 1);
                    //Link.GetConnectedLink(i).getIndex() + 1;
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
        private void ShowAvaliableLinks(Link Link)//Доступные узлы
        {
            Avaliable_to_connect.Items.Clear();
            if(Graph.GetNLinks() != 0)
            {
                for(int i = 0;i< Graph.GetNLinks(); i++)
                {
                    if(Graph.GetLink(i).getIndex()!=Link.getIndex() && !Link.FindConnectedLink(Graph.GetLink(i)))
                    Avaliable_to_connect.Items.Add(Graph.GetLink(i).getIndex()+1);
                }
            }
        }


        public LinkManager(Graph GRPH1, MainWindow MW)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            MainWindow = MW;
            Graph = GRPH1;
            for(int i = 0; i<Graph.GetNLinks();i++)
                LinksCombo.Items.Add($"{i+1}");
            LinkManagerLiveReaction += ShowLinkType;
            LinkManagerLiveReaction += ShowAllConnectedLinks;
            LinkManagerLiveReaction += ShowAvaliableLinks;
        }

        private void LinksCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (LinksCombo.SelectedIndex != -1)
            {
                LinkManagerLiveReaction.Invoke(Graph.GetLink(LinksCombo.SelectedIndex));
            }
        }
        //private void UpdateParametersInDB_Type(Link Link)
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(MainWindow.DatabaseConnectionContext))
        //    {

        //        //string commandstring = "INSERT INTO Graph ([Id],[Type],[Connects]) VALUES (@ID,@Type,@Connects)";
        //        string commandstring = $"UPDATE Graph SET Type = {Link.GetLinkType()} WHERE [Id] = {Link.getIndex()};";
        //        using (SQLiteCommand command = new SQLiteCommand(commandstring, connection))
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
        //private void UpdateParametersInDB_Con(Link Link)
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(MainWindow.DatabaseConnectionContext))
        //    {
        //        string ToDB = null;
        //        for (int j = 0; j < Link.GetLinks(); j++)
        //        {
        //            ToDB += $"{Link.GetConnectedLink(j).getIndex()} ";
        //        }
        //        //string commandstring = "INSERT INTO Graph ([Id],[Type],[Connects]) VALUES (@ID,@Type,@Connects)";
        //        string commandstring = null;
        //        if (ToDB != null) 
        //            commandstring = $"UPDATE Graph SET Connects = '{ToDB}' WHERE [Id] = {Link.getIndex()};";
        //        else
        //            commandstring = $"UPDATE Graph SET Connects = Null WHERE [Id] = {Link.getIndex()};";
        //        using (SQLiteCommand command = new SQLiteCommand(commandstring, connection))
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
        private void UpdateParametersInDB(Link Link)
        {
            using (SQLiteConnection connection = new SQLiteConnection(MainWindow.DatabaseConnectionContext))
            {
                string ToDB = null;
                for (int j = 0; j < Link.GetLinks(); j++)
                {
                    ToDB += $"{Link.GetConnectedLink(j).getIndex()} ";
                }
                //string commandstring = "INSERT INTO Graph ([Id],[Type],[Connects]) VALUES (@ID,@Type,@Connects)";
                string commandstring = null;
                if (ToDB != null)
                    commandstring = $"UPDATE Graph SET Type = {Link.GetLinkType()}, Connects = '{ToDB}' WHERE [Id] = {Link.getIndex()};";
                else
                    commandstring = $"UPDATE Graph SET Type = {Link.GetLinkType()}, Connects = Null WHERE [Id] = {Link.getIndex()};";
                using (SQLiteCommand command = new SQLiteCommand(commandstring, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ChangeTypeButton_Click(object sender, EventArgs e)
        {
            if(RB_Default.Checked) Graph.GetLink(LinksCombo.SelectedIndex).changeType(1);
            else
            {
                if(RB_Source.Checked) Graph.GetLink(LinksCombo.SelectedIndex).changeType(2);
                else
                {
                    if(RB_Consumer.Checked) Graph.GetLink(LinksCombo.SelectedIndex).changeType(3);
                    else
                    {
                        if(RB_Critical.Checked) Graph.GetLink(LinksCombo.SelectedIndex).changeType(4);
                    }
                }
            }
            if (MainWindow.DatabaseConnectionContext != null) UpdateParametersInDB(Graph.GetLink(LinksCombo.SelectedIndex));
        }

        private void всеУзлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkViewer linkViewer = new LinkViewer(Graph);
            linkViewer.ShowDialog();
        }

        private void AddConnect_Click(object sender, EventArgs e)
        {
            if (Avaliable_to_connect.SelectedItem == null || LinksCombo.SelectedItem==null)
            {
                MessageBox.Show("Узел для подключения не выбран.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                
                Graph.GetLink(Int32.Parse(LinksCombo.SelectedItem.ToString()) - 1).AddConnectedLink(Graph.GetLink(Int32.Parse(Avaliable_to_connect.SelectedItem.ToString()) - 1));
                LinkManagerLiveReaction.Invoke(Graph.GetLink(Int32.Parse(LinksCombo.SelectedItem.ToString()) - 1));
                DataGridUpd();
                if (MainWindow.DatabaseConnectionContext != null) UpdateParametersInDB(Graph.GetLink(LinksCombo.SelectedIndex));
            }
        }

        private void RemoveConnect_Click(object sender, EventArgs e)
        {
            if (Connected_links.SelectedItem == null || LinksCombo.SelectedItem == null)
            {
                MessageBox.Show("Узел для отключения не выбран.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int SItem =Int32.Parse(Connected_links.SelectedItem.ToString())-1;
                Link test = Graph.GetLink(SItem);
                SItem = Int32.Parse(LinksCombo.SelectedItem.ToString()) - 1;
                Graph.GetLink(SItem).RemoveConnectedLink(test.getIndex());
                Graph.GetLink(test.getIndex()).RemoveConnectedLink(SItem);
                LinkManagerLiveReaction.Invoke(Graph.GetLink(SItem));
                DataGridUpd();
                if (MainWindow.DatabaseConnectionContext != null) UpdateParametersInDB(Graph.GetLink(LinksCombo.SelectedIndex));
            }
        }

        private void Avaliable_to_connect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Avaliable_to_connect.SelectedItem != null)
            {
                int SItem = Int32.Parse(Avaliable_to_connect.SelectedItem.ToString()) - 1;

                switch (Graph.GetLink(SItem).GetLinkType())
                {
                    case 1: label4.Text = "Тип: Обычный"; break;
                    case 2: label4.Text = "Тип: Источник"; break;
                    case 3: label4.Text = "Тип: Потребитель"; break;
                    case 4: label4.Text = "Тип: Критический"; break;
                    default: label4.Text = "Тип: Обычный"; break;
                }
            }
        }

        private void Connected_links_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Connected_links.SelectedItem != null)
            {
                int SItem = Int32.Parse(Connected_links.SelectedItem.ToString()) - 1;
                switch (Graph.GetLink(SItem).GetLinkType())
                {
                    case 1: label5.Text = "Тип: Обычный"; break;
                    case 2: label5.Text = "Тип: Источник"; break;
                    case 3: label5.Text = "Тип: Потребитель"; break;
                    case 4: label5.Text = "Тип: Критический"; break;
                    default: label5.Text = "Тип: Обычный"; break;
                }
            }
        }
    }
}
