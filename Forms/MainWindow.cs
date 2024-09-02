using SynergicFailureAftermath.Forms;
using SynergicFailureAftermath.Classes;
using System;
using System.Windows.Forms;

using System.IO;
using System.Data.SQLite;
using System.Reflection;


namespace SynergicFailureAftermath
{


    public partial class MainWindow : Form
    {


        public string DatabaseConnectionContext = null;



        private Graph Main_Graph { get; set; }
        public void InitializeGraph()
        {
            Main_Graph = new Graph();
        }

        public MainWindow()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.Show();
        }

        private void добавитьУзелToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddLink AddLinkForm = new AddLink(Main_Graph, this);
            AddLinkForm.Owner = this;
            AddLinkForm.ShowDialog();

        }

        private void Init()
        {
            добавитьУзелToolStripMenuItem.Enabled = true;
            Graph_box.Enabled = true;
            InitializeGraph();
            MessageBox.Show("Программа подготовлена к работе", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartButton.Enabled = false;
            Graph_datagrid.ReadOnly = true;
            LinkManager.Enabled = true;
            ModellingButton.Enabled = true;
            удалитьузелToolStripMenuItem.Enabled = true;
            выходToolStripMenuItem.Enabled = true;
            загрузитьГрафToolStripMenuItem.Enabled = true;
        }

        private void CreateDatabase(string Filename)
        {
            DatabaseConnectionContext = "Data Source=" + Filename + "; Version=3;";
            SQLiteConnection.CreateFile(Filename);
            using (SQLiteConnection Connect = new SQLiteConnection(DatabaseConnectionContext))
            {
                string commandstring = "CREATE TABLE Graph(Id INTENGER, Type INTENGER, Connects TEXT);CREATE TABLE Subsets(Id INTENGER, Subset TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(commandstring, Connect))
                {
                    Connect.Open();
                    command.ExecuteNonQuery();
                }
            }

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Создать базу данных для записи?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                CreateDBDialog = new SaveFileDialog();
                CreateDBDialog.Filter = "SQLite database (*.db)|*.db";
                CreateDBDialog.FilterIndex = 1;
                try
                {
                    if (CreateDBDialog.ShowDialog() == DialogResult.OK)
                    {
                        CreateDatabase(CreateDBDialog.FileName);
                        менеджерБазДанныхToolStripMenuItem.Enabled = true;
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Файл не может быть прочитан. Сообщение об ошибке: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                Init();
                
            }
            else Init();

        }

        private void LinkManager_Click(object sender, EventArgs e)
        {
            LinkManager linkManager = new LinkManager(Main_Graph, this);
            linkManager.ShowDialog();
        }

        private void ModellingButton_Click(object sender, EventArgs e)
        {
            Modelling modelling = new Modelling(Main_Graph,this);
            modelling.ShowDialog();
        }
        private void InitializeDB()
        {
            for (int i = 0; i < Main_Graph.GetNLinks(); i++)
            {
                Link Record = Main_Graph.GetLink(i);
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseConnectionContext))
                {
                    string commandstring = "INSERT INTO Graph ([Id],[Type],[Connects]) VALUES (@ID,@Type,@Connects)";
                    using (SQLiteCommand command = new SQLiteCommand(commandstring, connection))
                    {
                        connection.Open();
                        string ToDB = null;
                        command.Parameters.AddWithValue("ID", Record.getIndex());
                        command.Parameters.AddWithValue("Type", Record.GetLinkType());
                        for (int j = 0; j < Record.GetLinks(); j++)
                        {
                            ToDB += $"{Record.GetConnectedLink(j).getIndex()} ";
                        }
                        command.Parameters.AddWithValue("Connects", ToDB);
                        command.ExecuteNonQuery();
                    }
                }
            }
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
            DatabaseConnectionContext = null;
            менеджерБазДанныхToolStripMenuItem.Enabled = false;
            MessageBox.Show("Граф удалён.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                Savefile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                Savefile.FilterIndex = 1;
                if (Savefile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(Savefile.FileName);
                    Main_Graph.RecordFileToWindows(writer);
                }
            }

        }

        private void загрузитьГрафToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile = new OpenFileDialog();
            OpenFile.Filter = "txt files (*.txt)|*.txt|SQLite database (*.db)|*.db";
            OpenFile.FilterIndex = 1;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                if (OpenFile.FileName != null)
                {
                    if (!OpenFile.FileName.Contains(".db"))
                    {
                        Main_Graph = new Graph();
                        Graph_datagrid.Rows.Clear();
                        Graph_datagrid.Columns.Clear();
                        StreamReader Reader = new StreamReader(OpenFile.FileName);
                        Main_Graph.ReadFileFromWindows(Reader, this);
                        if(DatabaseConnectionContext!=null)
                            InitializeDB();
                    }
                    else
                    {
                        DBReader(OpenFile.FileName);
                    }
                }
                
            }
        }

        private void DBReader(string Filename)
        {
            менеджерБазДанныхToolStripMenuItem.Enabled = true;
            DatabaseConnectionContext = "Data Source=" + Filename + "; Version=3;";
            Main_Graph.ReadDatabaseFromWindows(DatabaseConnectionContext, this);
        }

        private void Graph_datagrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //if (Main_Graph.GetNLinks() > 0)
            //{
            //    Link Record = Main_Graph.GetLink(Main_Graph.GetNLinks()-1);
            //    using (SQLiteConnection connection = new SQLiteConnection(DatabaseConnectionContext))
            //    {
            //        string commandstring = "INSERT INTO Graph ([Id],[Type],[Connects]) VALUES (@ID,@Type,@Connects)";
            //        using (SQLiteCommand command = new SQLiteCommand(commandstring, connection))
            //        {
            //            connection.Open();
            //            string ToDB = null;
            //            command.Parameters.AddWithValue("ID", Record.getIndex());
            //            command.Parameters.AddWithValue("Type", Record.GetLinkType());
            //            for (int j = 0; j < Record.GetLinks(); j++)
            //            {
            //                ToDB += $"{Record.GetConnectedLink(j).getIndex()} ";
            //            }
            //            command.Parameters.AddWithValue("@Connects", ToDB);
            //            command.ExecuteNonQuery();
            //        }
            //    }
            //}
        }

        private void менеджерБазДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseViewer databaseViewer = new DatabaseViewer(this);
            databaseViewer.ShowDialog();
        }
    }
}
