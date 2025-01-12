using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckmateAppFinal
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst27DataSet.Customer);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurnam.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtContact.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRewards.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillByName(groupWst27DataSet.Customer, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm91 = new Form4();
            frm91.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.groupWst27DataSet.Customer);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            customerTableAdapter.DeleteCust(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //customerTableAdapter.UpdateCustDetails(txtName.)
        }

        private void button12_Click(object sender, EventArgs e)
        {
            customerTableAdapter.AddCustomer(txtName.Text, txtSurnam.Text, txtAddress.Text, txtEmail.Text, txtContact.Text, decimal.Parse(txtRewards.Text));
        }
    }
}
