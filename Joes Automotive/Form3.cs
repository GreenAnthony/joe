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
    public partial class showCustomersButton : Form
    {
        public showCustomersButton()
        {
            InitializeComponent();
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.SearchCust(
                this.customersDataSet.Customers, searchButton.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
