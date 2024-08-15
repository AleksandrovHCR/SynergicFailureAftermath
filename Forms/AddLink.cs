using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SynergicFailureAftermath.Classes;
using SynergicFailureAftermath.Forms;

namespace SynergicFailureAftermath
{

    public partial class AddLink : Form
    {
        //public delegate void GraphLiveReaction(string message, int Value);
        public delegate void GraphLiveReaction();
        public event GraphLiveReaction LinkAddedInCollection;
        MainWindow MainWindow;
        public Graph GRPH { get; private set; }

        // private void InfoUpd(string message, int Value) 
        private void InfoUpd()
        {
            //InfoLabel.Text = message + Value.ToString();
            InfoLabel.Text = $"Количество узлов: {GRPH.GetNLinks()}";
        }//$"Количество узлов:{GRPH.GetNLinks()}";

        public void DataGridUpd()
        {

            MainWindow.Graph_datagrid.ColumnCount = GRPH.GetNLinks() + 1;
            MainWindow.Graph_datagrid.Columns[GRPH.GetNLinks()].Name = $"{GRPH.GetNLinks()}";
            MainWindow.Graph_datagrid.Rows.Add();
            MainWindow.Graph_datagrid[0, GRPH.GetNLinks() - 1].Value = GRPH.GetNLinks();
            MainWindow.Graph_datagrid[GRPH.GetNLinks(), GRPH.GetNLinks() - 1].Value = "-";
        }

        public AddLink(Graph GRPH1, MainWindow MW)
        {
            InitializeComponent();
            LinkTypeComboBox.Items.AddRange(new string[] { "Обычный", "Источник", "Потребитель", "Критический" });

            GRPH = GRPH1;
            MainWindow = MW;
            LinkAddedInCollection += new GraphLiveReaction(this.InfoUpd);
            // LinkAddedInCollection.Invoke($"Количество узлов: ", GRPH.GetNLinks());
            LinkAddedInCollection.Invoke();
            LinkAddedInCollection += DataGridUpd;
        }


        private bool CheckTextBox()
        {
            if (HowMuchToAdd.Text == null) return false;
            for (int i = 0; i < HowMuchToAdd.Text.Length; i++)
            {
                if (HowMuchToAdd.Text[i] < 48 || HowMuchToAdd.Text[i] > 57)
                    return false;
            }
            if (Int32.Parse(HowMuchToAdd.Text) < 0 || Int32.Parse(HowMuchToAdd.Text)>654) return false;
            return true;
        }
        private void AddNewLink_Click(object sender, EventArgs e)
        {
            if (LinkTypeComboBox.SelectedItem == null ||!CheckTextBox())
            {
                MessageBox.Show("Не задан тип узла или неправильно указано число добавляемых узлов. Можно добавить не больше 654 узлов за раз.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < Int32.Parse(HowMuchToAdd.Text); i++)
                {
                    Link NewLink = new Link(GRPH.GetNLinks(), LinkTypeComboBox.SelectedIndex + 1);
                    GRPH.AddLink(NewLink);
                    LinkAddedInCollection.Invoke();
                }
                //Close();
            }
           
        }

        private void AddAndExit_Click(object sender, EventArgs e)
        {
            if (LinkTypeComboBox.SelectedItem == null || !CheckTextBox())
            {
                MessageBox.Show("Не задан тип узла или неправильно указано число добавляемых узлов. Можно добавить не больше 654 узлов за раз.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < Int32.Parse(HowMuchToAdd.Text); i++)
                {
                    Link NewLink = new Link(GRPH.GetNLinks(), LinkTypeComboBox.SelectedIndex + 1);
                    GRPH.AddLink(NewLink);
                    LinkAddedInCollection.Invoke();
                }
                Close();
            }
        }

        private void AddLink_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
