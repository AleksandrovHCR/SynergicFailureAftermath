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
        private List<Result> Results;
        private Graph Graph;

        private bool GetTotalFailure()
        {
            foreach(Failure failure in Failures)
            {
                if(failure.GetCriticalLinks().Count==Graph.GetCriticalLinksCount())
                    return true;
            }
            return false;
        }

        private void UpdateResultsGrid() {
            ResultLog.Rows.Clear();
            for(int i = 0;i<Results.Count;i++)
            {
                ResultLog.Rows.Add();
                ResultLog[0, i].Value = Results[i].GetIndex()+1;
                ResultLog[1, i].Value = Results[i].GetMnojestva();
                ResultLog[2, i].Value = Results[i].GetScale();
            }
        }

        private void UpdateGrid()
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
                //for (int j = 0; j < Failures[i].GetScaleOfFailure(); j++)
                //{
                //    if (Failures[i].GetBreaked(j).GetLinkType()==3)
                //        temp += $"{Failures[i].GetBreaked(j).getIndex() + 1}; ";
                //}
                foreach(Link link in Failures[i].GetConsumers())
                {
                    temp += $"{link.getIndex()+1}; ";
                }
                FailureLog[2,i].Value = temp;
            }
        }

        private void UpdateLists()
        {
            SelectableNotes.Items.Clear();
            CalculatableNotes.Items.Clear();

            for(int i = 0; i < Failures.Count; i++)
            {
                if(Failures[i].GetCriticalLinks().Count!=Graph.GetCriticalLinksCount())
                SelectableNotes.Items.Add(Failures[i].GetIndex()+1);
            }

        }


        public SynergeticFailureAftermatch(List<Failure> failures,Graph Graph)
        {
            InitializeComponent();
            Failures = failures;
            this.Graph = Graph;
            UpdateGrid();
            UpdateLists();
            Results=new List<Result>() { };
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

       //private int Factorial(int n)
       // {
       //     int x=0;
       //     for ( int i = 1; i < n+1; i++)
       //     {
       //         x *= i;
       //     }
       //     return x;
       // }
       // private int Combine(int x, int y)
       // {
       //     return Factorial(x) / (Factorial(y) * Factorial(x - y));
       // }

        private void Calculation_Click(object sender, EventArgs e)
        {
            if (!automatizeTheCalculations.Checked)
            {
                if (CalculatableNotes.Items.Count != 0)
                {
                    int Summ = 0;
                    string temp = "";
                    for (int i = 0; i < CalculatableNotes.Items.Count; i++)
                    {
                        int tmp = Int32.Parse(CalculatableNotes.Items[i].ToString()) - 1;
                        Failure Fail = Failures[tmp];
                        Summ += Fail.GetScaleOfFailure();

                        temp += Fail.GCL_string() + ' ';
                    }
                    Result result = new Result(Results.Count, temp, Summ);
                    Results.Add(result);
                    UpdateResultsGrid();
                    UpdateLists();
                }
                else
                {
                    MessageBox.Show("Записи для вычислений не выбраны.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //Здесь должен быть код для автоматизации расчётов
                Combination Ethalon = null;
                foreach (Failure fail in Failures)//Поиск множества
                {
                    if (fail.IsTotalFailure())
                    {
                        Ethalon = new Combination(fail); break;
                    }
                }
                List<Combination> Combinations = new List<Combination>();//хранение разбиений
                Combination Main_combination= new Combination();//Комбинация-шаблон
                foreach(Failure fail in Failures)//
                {
                    if(fail.GetCriticalLinks().Count==1)
                        Main_combination.Add(fail);
                    if (Main_combination.getLength() == Ethalon.getLength())
                        break;
                }
                List<int> Lengths_of_subsets = new List<int>();//Длины подмножеств для комбинаций
                for(int i = 2;i<Ethalon.getLength();i++)
                    Lengths_of_subsets.Add(i);

                foreach(int  length in Lengths_of_subsets)//Построение комбинаций (Исправить)
                {
                    foreach(Failure failure in Failures)
                    {
                        Combination Temp = Main_combination;
                        if (!Temp.IsContainPart(failure) && failure.GetCriticalLinks().Count == length)
                        {
                            Temp.Copy_and_replace(Temp, failure);
                            Combinations.Add(Temp);
                        }
                    }
                }
                for(int i = 0; i < Combinations.Count; i++)
                {
                    Results.Add(Combinations[i].ConvertToResult(i));
                }
                UpdateResultsGrid();
            }
        }

        //Низкопольные элки придумали трусы

        private void FinalCalculate_Click(object sender, EventArgs e)
        {
            if (ResultLog != null && GetTotalFailure() && Results.Count>0)
            {
                Failure failure = null;
                foreach(Failure Fail in Failures) {
                    if (Fail.IsTotalFailure())
                    {
                        failure = Fail;;//C(F)
                        Failures.Remove(Fail);
                        break;
                    }
                }
                int max = 0;
                //foreach (Failure Fail in Failures)
                //{
                //    if(Fail.GetScaleOfFailure() > max) max= Fail.GetScaleOfFailure();
                //}
                foreach(Result result in Results)
                {
                    if(result.GetScale()>max)max = result.GetScale();
                }
                SFA_Result.Text = $"{failure.GetScaleOfFailure() - max}";
                Failures.Add(failure);
                MessageBox.Show($"Расчёты завершены. Результат поиска синергетических последствий отказа: {failure.GetScaleOfFailure() - max} ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); ; ;
            }
            else
            {
                MessageBox.Show("Список результатов пуст или не рассчитаны последствия полного отказа.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void automatizeTheCalculations_CheckedChanged(object sender, EventArgs e)
        {
            if(automatizeTheCalculations.Checked)
            {
                SelectableNotes.Enabled = false;
                AddToSumm.Enabled = false;
                RemoveFromSumm.Enabled=false;
                CalculatableNotes.Enabled = false;
            }
            else
            {
                SelectableNotes.Enabled = true;
                AddToSumm.Enabled = true;
                RemoveFromSumm.Enabled = true;
                CalculatableNotes.Enabled = true;
            }
        }

    }
}
