using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DoneOperations : Form
    {
        public DoneOperations()
        {
            InitializeComponent();

            doneOperationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DoneOperations_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            SqlCommand command = new SqlCommand("SELECT Paid.PaidID FROM Paid  ", dB.GetConnection());

            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                dB.closedConnection();
                this.Close();
            }
            else
            {
                dB.closedConnection();
                LoadData();
            }
        }

        public void LoadData()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlCommand sqlCommand = new SqlCommand("SELECT BuyerID, (SELECT Buyer.BuyerName FROM Buyer WHERE DocExp.BuyerID = Buyer.BuyerID) AS " +
                    "BuyerName,SUM(Quantity * Price) AS Cost FROM Paid INNER JOIN DocExp ON DocExp.DocExpID = Paid.DocExpID GROUP BY DocExp.BuyerID", db.GetConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.doneOperationDataGridView.DataSource = dataTable;
                this.doneOperationDataGridView.Columns[0].Visible = false;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                db.closedConnection();
            }
        }

        private void moreToolStripButton_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            SqlCommand command = new SqlCommand("SELECT Paid.PaidID FROM Paid  ", dB.GetConnection());

            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                dB.closedConnection();
                MessageBox.Show("Error");
                this.Close();
            }
            else
            {
                dB.closedConnection();

                int rowIndex = doneOperationDataGridView.CurrentCell.RowIndex;
                string id = doneOperationDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                moreDoneOperationsForm moreDoneOperationsForm = new moreDoneOperationsForm(id);
                moreDoneOperationsForm.ShowDialog();
                LoadData();
            }
        }
    }
}
