using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void namesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Names n = new Names();
            n.Show(this);
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Show(this);
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expences expenses = new Expences();
            expenses.ShowDialog();
        }

        private void կատարվածԳործողություններToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoneOperations doneOperations = new DoneOperations();
            doneOperations.Show();
        }

        private void գնորդToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyerForm buyerForm = new BuyerForm();
            buyerForm.Show();
        }
    }
}
