using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        DataTable table = new DataTable();
        int selectedRow;
        
        private void workButton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showCustomersButton_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("City, State, Zip", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add("Anthony Green", "Bay City, MI, 48706", "600 westlawn st", "9894506656", "agreen_2001@yahoo.com");
            table.Rows.Add("Billy Bob", "Melbourne, FL, 39204", "123 6th st", "2515469442", "billbob_4557@yahoo.com");
            table.Rows.Add("Matt Tress", "Chevy Chase, MD, 20815", "71 Pilgrim Avenue", "1255464478", "tress_4573@yahoo.com");
            table.Rows.Add("John Smith", "South Windsor, CT, 06074", "70 Bowman St", "9495694371", "jsmith_2001@yahoo.com");

            dataGridView1.DataSource = table;

        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
           table.Rows.Add(nameBox.Text, areaBox.Text, addressBox.Text, phoneBox.Text, emailBox.Text);
            dataGridView1.DataSource = table;

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            nameBox.Text = row.Cells[0].Value.ToString();
            areaBox.Text = row.Cells[1].Value.ToString();
            addressBox.Text = row.Cells[2].Value.ToString();
            phoneBox.Text = row.Cells[3].Value.ToString();
            emailBox.Text = row.Cells[4].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = nameBox.Text;
            newDataRow.Cells[1].Value = areaBox.Text;
            newDataRow.Cells[2].Value = addressBox.Text;
            newDataRow.Cells[3].Value = phoneBox.Text;
            newDataRow.Cells[4].Value = emailBox.Text;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e) 
        {
           if (string.IsNullOrEmpty(customersSearch.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }            
           else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name='{0}'", customersSearch.Text);
            }
        }

        private void customersSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", customersSearch.Text);
        }
    }
}
