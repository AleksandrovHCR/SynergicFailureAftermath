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

namespace SynergicFailureAftermath.Forms
{
    public partial class DatabaseViewer : Form
    {
        private MainWindow MW;
        public DatabaseViewer(MainWindow MW)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MW = MW;
            label1.Text = "Соединение: " + MW.DatabaseConnectionContext;
        }
        private void LoadDGW()
        {
            Links.DataSource = GetDataFromDB("Graph");
            Subsets.DataSource = GetDataFromDB("Subsets");
        }

        private DataTable GetDataFromDB(string Tablet)
        {
            DataTable dataTableSubsets = new DataTable();
            using (SQLiteConnection Connection = new SQLiteConnection(MW.DatabaseConnectionContext))
            {
                string cmd = "SELECT * FROM "+Tablet;
                using (SQLiteCommand command = new SQLiteCommand(cmd, Connection))
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                    SQLiteDataReader reader = command.ExecuteReader();
                    dataTableSubsets.Load(reader);
                }
            }
            return dataTableSubsets;
        }
        private void DatabaseVewer_Load(object sender, EventArgs e)
        {
            LoadDGW();
        }
    }
}
