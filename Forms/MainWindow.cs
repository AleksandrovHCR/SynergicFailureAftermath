using SynergicFailureAftermath.Forms;
using SynergicFailureAftermath.Classes;
using System;
using System.Windows.Forms;

namespace SynergicFailureAftermath
{
    public struct GRPH
    {
        Graphs Graph;
    }
    public partial class MainWindow : Form
    { 
        
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
            AddLink AddLinkForm=new AddLink();
            AddLinkForm.Owner = this;
            AddLinkForm.ShowDialog();
            
        }
       
    }
}
