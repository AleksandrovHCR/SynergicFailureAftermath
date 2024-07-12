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
    public partial class SynergeticFailureAftermatch : Form
    {

        private List<Failure> Failures;

        private void updateGrid()
        {
            for(int i=0;i<Failures.Count;i++)
            {
                FailureLog.Rows.Add();
                FailureLog[0, i].Value = i+1;
                List<Link> links = Failures[i].GetCriticalLinks();
                string temp=null;
                for (int j = 0; j < Failures[i].GetCriticalLinks().Count; j++)
                {
                    temp += $"{links[j].getIndex()+1}; ";
                }
                FailureLog[1, i].Value = temp;
                temp = null;
                for (int j = 0; j < Failures[i].GetScaleOfFailure(); j++)
                    temp += $"{Failures[i].GetBreaked(j).getIndex()+1}; ";
                FailureLog[2,i].Value = temp;
            }
        }

        private void UpdateLists()
        {
            SelectableNotes.Items.Clear();
            CalculatableNotes.Items.Clear();

            for(int i = 0; i < Failures.Count; i++)
            {
                SelectableNotes.Items.Add(Failures[i].GetIndex()+1);
            }

        }


        public SynergeticFailureAftermatch(List<Failure> failures)
        {
            InitializeComponent();
            Failures = failures;
            updateGrid();
            UpdateLists();

        }

        private void SelectableNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToSumm_Click(object sender, EventArgs e)
        {
            if (SelectableNotes.SelectedItem != null)
            {
                CalculatableNotes.Items.Add(SelectableNotes.SelectedItem.ToString());
                SelectableNotes.Items.Remove(SelectableNotes.SelectedItem);
                
            }
        }

        private void RemoveFromSumm_Click(object sender, EventArgs e)
        {
            if(CalculatableNotes.SelectedItem != null)
            {
                SelectableNotes.Items.Add(CalculatableNotes.SelectedItem.ToString());
                CalculatableNotes.Items.Remove(CalculatableNotes.SelectedItem.ToString());
            }
        }

        private void Calculation_Click(object sender, EventArgs e)
        {

        }
    }
}
