using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynergicFailureAftermath.Classes;

namespace SynergicFailureAftermath.Forms
{
    public partial class BreakOnSubsets : Form
    {
        private List<Subset> Subsets;
        private List<int> Main_Set;


        private void UpdateResults()
        {
            ListOfSubsets.Rows.Clear();
            for (int i = 0; i < Subsets.Count; i++)
            {
                ListOfSubsets.Rows.Add();
                ListOfSubsets[0, i].Value = Subsets[i].GetIndex() + 1;
                string temp = null;
                foreach (int Item in Subsets[i].GetItems())
                {
                    temp += Item + 1 + "; ";
                }
                ListOfSubsets[1, i].Value = temp;
            }
        }
        


        public BreakOnSubsets(List<Subset> subsets, List<int> main_Set)
        {
            InitializeComponent();
            this.Subsets = subsets;
            Main_Set = main_Set;
            foreach(int i in Main_Set)
            {
                CLinks.Text += $"{i+1}; ";
            }
        }


        private List<HashSet<T>> GetSubsets<T>(HashSet<T> set)
        {
            var subsets = new List<HashSet<T>>();
            for (int subsetSize = 1; subsetSize <= set.Count; subsetSize++)
            {
                var combinations = GetCombinations(set, subsetSize);
                subsets.AddRange(combinations);
            }
            return subsets;
        }
        private List<HashSet<T>> GetCombinations<T>(HashSet<T> set, int size)
        {
            var combinations = new List<HashSet<T>>();
            GetCombinationsHelper(set, size, 0, new HashSet<T>(), combinations);
            return combinations;
        }

        private void GetCombinationsHelper<T>(HashSet<T> set, int size, int startIndex, HashSet<T> currentSubset, List<HashSet<T>> combinations)
        {
            if (currentSubset.Count == size)
            {
                combinations.Add(new HashSet<T>(currentSubset));
                return;
            }

            for (int i = startIndex; i < set.Count; i++)
            {
                currentSubset.Add(set.ElementAt(i));
                GetCombinationsHelper(set, size, i + 1, currentSubset, combinations);
                currentSubset.Remove(set.ElementAt(i));
            }
        }

        private void StartTheBreakage_Click(object sender, EventArgs e)
        {
            var HSet=new HashSet<int>() { };
            foreach (var element in Main_Set)
            {
                HSet.Add(element);
            }

            var Subsets1 = GetSubsets(HSet);
            for(int i= 0; i < Subsets1.Count; i++)
            {
                Subset temp = new Subset(i, Subsets1[i]);
                Subsets.Add(temp);
            }            
            UpdateResults();
            StartTheBreakage.Enabled = false;
        }
    }
}
