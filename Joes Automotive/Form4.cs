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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void invoicesButton_Click(object sender, EventArgs e)
        {
            if (oilBox.Checked == true)
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void oilBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oilBox.Checked == true)
            {
                oilMoney.Text = 55.ToString();
            }
            else
            {
                oilMoney.Text = 0.ToString();
            }
        }
    }
}
