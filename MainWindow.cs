using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinergicFailureAftermath
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lorem ipsum");
        }

        private void добавитьУзелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLink AddLinkForm=new AddLink();
            AddLinkForm.ShowDialog();
        }
    }
}
