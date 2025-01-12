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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

       

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet.Order_Item' table. You can move, or remove it, as needed.
            this.order_ItemTableAdapter.Fill(this.groupWst27DataSet.Order_Item);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Order_Item' table. You can move, or remove it, as needed.
            this.order_ItemTableAdapter.Fill(this.groupWst27DataSet.Order_Item);
            // TODO: This line of code loads data into the 'groupWst27DataSet2.Order_Item' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'groupWst27DataSet1.Order_Item' table. You can move, or remove it, as needed.
            this.order_ItemTableAdapter.Fill(this.groupWst27DataSet1.Order_Item);
            //// TODO: This line of code loads data into the 'groupWst27DataSet.Sale' table. You can move, or remove it, as needed.
            //this.saleTableAdapter.Fill(this.groupWst27DataSet.Sale);
            //// TODO: This line of code loads data into the 'groupWst27DataSet.Sale' table. You can move, or remove it, as needed.
            //this.saleTableAdapter.Fill(this.groupWst27DataSet.Sale);
            //// TODO: This line of code loads data into the 'groupWst27DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst27DataSet.Customer);
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            Form7 frm7 = new Form7();
            int ID = 1;
            DialogResult results = MessageBox.Show("View Reports?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(results == DialogResult.Yes)
            {
                Form8 frm8 = new Form8();
                this.Hide();
                frm8.ShowDialog();

            }
            else
            {
                Form_MainMenu frm2 = new Form_MainMenu();
                this.Hide();
                frm2.ShowDialog();
            }


            //frm8.label7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            // saleTableAdapter.Insert(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0]), EmployeeID(), EmployeeID(), DateTime.Now, frm7.Payment.Text,Convert.ToDecimal(frm7.textBox2.Text)) ;



        }
        private int EmployeeID()
        {
            int id = 0;
            for(int i = 0;i < 2; i++)
            {
                id += i;
            }
            return id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillByName(groupWst27DataSet.Customer, textBox1.Text);

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }
       /** public void LoadData(List<string> data)
        {
            dataGridView1.Rows.Clear();

            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }*/

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                saleTableAdapter.FillByID(groupWst27DataSet.Sale, (int)dataGridView2.CurrentRow.Cells[0].Value);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.ForeColor = Color.Aqua;
            for(int i  = 0;i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                    label7.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillByName(groupWst27DataSet.Customer, textBox1.Text);
        }
        // Public method to remove rows based on a date column
        public void RemoveRowsByDate1(DateTime dateToRemove)
        {


            // Your date handling logic here
            // Loop through the rows in the DataGridView
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                DateTime date = DateTime.Today;
                if (row.Cells["Sale_Date"].Value.Equals(date))

                {
                    if (date.Date == dateToRemove.Date)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
            

        
        }


        public void RemoveRowsByDate(DateTime dateToRemove)
        {


            // Your date handling logic here
            // Loop through the rows in the DataGridView
            for (int i = dataGridView3.Rows.Count - 1; i >= 0; i++)
            {
                DataGridViewRow row = dataGridView3.Rows[i];
                DateTime date = DateTime.Today;
                if (row.Cells["Order_Date"].Value.Equals(date))

                {
                    if (date.Date == dateToRemove.Date)
                    {
                        dataGridView3.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void dataGridView4_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView4.CurrentRow.Cells[0].Value != null)
            {
                order_ItemTableAdapter.FillByID(groupWst27DataSet.Order_Item, (int)dataGridView4.CurrentRow.Cells[0].Value);
            }
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView4.CurrentRow.Cells[0].Value != null)
            {
                order_ItemTableAdapter.FillByID(groupWst27DataSet.Order_Item, (int)dataGridView4.CurrentRow.Cells[0].Value);
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
