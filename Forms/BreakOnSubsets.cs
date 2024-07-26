using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Subsets.Count == 0)
            {
                MessageBox.Show("Разбиение на подмножества не проведено.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveTheResults = new SaveFileDialog();
                SaveTheResults.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                SaveTheResults.FilterIndex = 1;
                if (SaveTheResults.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter Writer1 = new StreamWriter(SaveTheResults.FileName);
                    foreach (var element in Subsets)
                    {
                        string Writer2 = null;
                        foreach (var element1 in element.GetItems())
                            Writer2 += element1.ToString()+" ";
                        
                        Writer1.WriteLine(Writer2);
                    }
                    Writer1.Close();
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var HSet = new HashSet<int>() { };//Для защиты от дурака
            foreach (var element in Main_Set)
            {
                HSet.Add(element);
            }
            OpenFile = new OpenFileDialog();
            OpenFile.Filter = "txt files (*.txt)|*.txt";
            OpenFile.FilterIndex = 1;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                if (OpenFile.FileName != null && Main_Set.Count!=0)
                {
                    ListOfSubsets.Rows.Clear();
                    StreamReader Reader1 = new StreamReader(OpenFile.FileName);
                    try
                    {
                        int CurrentItem= 0;
                        while (!Reader1.EndOfStream)
                        {
                            
                            string[] Reader2 = Reader1.ReadLine().Split(' ');
                            HashSet<int> SetKeep= new HashSet<int>() { };
                            for(int Index=0;Index<Reader2.Length-1;Index++)
                            {
                                SetKeep.Add(Int32.Parse(Reader2[Index]));
                            }
                            Subset AddableSubset = new Subset(CurrentItem, SetKeep);
                            Subsets.Add(AddableSubset);
                            CurrentItem++;
                        }
                        foreach(Subset s in Subsets)
                        {
                            if (s.GetItems().Count==HSet.Count)
                            {
                                int Equaials = 0;
                               List<int> Temp1= new List<int>() { };
                                foreach(int tmp in s.GetItems())
                                {
                                    Temp1.Add(tmp);
                                }
                               List<int> Temp2 = new List<int>() { };
                                foreach (int tmp in HSet)
                                {
                                    Temp2.Add(tmp);
                                }
                                //foreach (int tmp in Temp2)
                                //{
                                //    foreach (int tmp2 in Temp1)
                                //    {
                                //        if (Temp1.Contains(tmp2))
                                //        {
                                //            Equaials++;
                                //        }
                                //    }
                                //}
                                for(int i = 0; i < Temp1.Count; i++)//Защита от загрузки неподходящего разбиения
                                {
                                    if(Temp1[i] == Temp2[i])
                                        Equaials++;
                                }
                                if (Equaials == HSet.Count)
                                {
                                    break;
                                }
                                else
                                {
                                    throw new Exception("Набор разбиений не соответствует графу.");
                                }
                            }
                            
                        }
                        
                        загрузитьToolStripMenuItem.Enabled = false;
                        UpdateResults();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Файл не может быть прочитан. Сообщение об ошибке: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Subsets.Clear();
                    }
                }
            }
        }
    }
}
