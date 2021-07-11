using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class moreDoneOperationsForm : Form
    {

        //0  PaidID
        //1  DocExpID
        //2  XumbName
        //3  ProductName
        //4  quantity
        //5  Price
        //6  Cost
        //7  BuyerName
        //8 Amsativ
        //9 AmsativNow
        public moreDoneOperationsForm(string index)
        {
            InitializeComponent();
            moreDoneOperationsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.buyerNameLabel.Text = index;
            this.buyerNameLabel.Visible = false;

        }

        private void moreDoneOperationsForm_Load(object sender, EventArgs e)
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
            string id = this.buyerNameLabel.Text;
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlCommand sqlCommand = new SqlCommand("SELECT Paid.PaidID, Paid.DocExpID,XumbName, ProducNames,Paid.Quantity,Paid.Price, " +
                    "(Quantity*Price) AS Cost ,(SELECT BuyerName FROM Buyer WHERE Buyer.BuyerID = '" + id + "') AS BuyName, Amsativ, AmsativNow " +
                    "FROM DocExp INNER JOIN Paid ON Paid.DocExpID = DocExp.DocExpID INNER JOIN Names ON Names.NamesID = Paid.NamesID INNER JOIN" +
                    " Xumb ON Xumb.XumbID = Names.XumbID WHERE BuyerID = '"+ id + "'", db.GetConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.moreDoneOperationsDataGridView.DataSource = dataTable;
                this.moreDoneOperationsDataGridView.Columns[0].Visible = false;
                this.moreDoneOperationsDataGridView.Columns[1].Visible = false;
                this.moreDoneOperationsDataGridView.Columns[2].HeaderText = "Xumb";
                this.moreDoneOperationsDataGridView.Columns[3].HeaderText = "Product Name";
                this.moreDoneOperationsDataGridView.Columns[4].HeaderText = "Quantity";
                this.moreDoneOperationsDataGridView.Columns[5].HeaderText = "Price";
                this.moreDoneOperationsDataGridView.Columns[7].HeaderText = "Buyer Name";
                this.moreDoneOperationsDataGridView.Columns[8].HeaderText = "Order Date";
                this.moreDoneOperationsDataGridView.Columns[9].HeaderText = "Insuse Order Date";

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

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (moreDoneOperationsDataGridView.CurrentCell != null)
            {
                int rowIndex = moreDoneOperationsDataGridView.CurrentCell.RowIndex;
                string paidId = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                string docId = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[1].Value.ToString();


                DB db = new DB();

                try
                {
                    db.openConnection();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("DELETE  Paid WHERE  Paid.PaidID = '" + paidId + "' ", db.GetConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.Message);
                }
                finally
                {
                    db.closedConnection();
                    LoadData();
                }

                db.openConnection();

                SqlCommand command2 = new SqlCommand("SELECT  DocExp.BuyerID FROM  DocExp INNER JOIN Paid ON DocExp.DocExpID = Paid.DocExpID  " +
                    "WHERE  Paid.DocExpID ='" + docId + "'", db.GetConnection());

                SqlDataReader reader = command2.ExecuteReader();

                if (!reader.Read())
                {
                    db.closedConnection();
                    try
                    {
                        db.openConnection();
                        DataTable table1 = new DataTable();
                        SqlCommand command1 = new SqlCommand("DELETE  DocExp WHERE  DocExp.DocExpID = '" + docId + "' ", db.GetConnection());
                        SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                        adapter1.Fill(table1);
                    }

                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                    }
                    finally
                    {
                        db.closedConnection();
                    }
                }
                else
                {
                    db.closedConnection();
                    MessageBox.Show("You can't delete this group because it is used");
                }
            }
            else
            {
                MessageBox.Show("Please select an item that you want delete");
            }
        }

        private void updateToolStripButton_Click(object sender, EventArgs e)
        {
            if (moreDoneOperationsDataGridView.CurrentCell != null)
            {
                int rowIndex = moreDoneOperationsDataGridView.CurrentCell.RowIndex;
                string oldproduct = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                string oldquantity = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
                string oldprice = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
                DateTime olddate = Convert.ToDateTime(moreDoneOperationsDataGridView.Rows[rowIndex].Cells[8].Value);
                string olddatenow = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[9].Value.ToString();
                string paidId = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                string docId = moreDoneOperationsDataGridView.Rows[rowIndex].Cells[1].Value.ToString();


                EditDoneOperationsForm editDoneOperationsForm = new EditDoneOperationsForm(paidId, docId, oldproduct, oldquantity, oldprice, olddate, olddatenow);
                editDoneOperationsForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an item that you want edit");
            }
            LoadData();
        }    
    }
}
