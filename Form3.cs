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
    
    public partial class Form3 : Form
    {
        public string newStatus = "";
        public Form3()
        {
            InitializeComponent();
            // Create the BindingSource
           
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet1.Supplier_Order' table. You can move, or remove it, as needed.
            this.supplier_OrderTableAdapter.Fill(this.groupWst27DataSet1.Supplier_Order);
            // TODO: This line of code loads data into the 'groupWst27DataSet1.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.groupWst27DataSet1.Stock);
            stockTableAdapter.Fill(groupWst27DataSet1.Stock);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Product_Item' table. You can move, or remove it, as needed.
            this.product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainMenu frmMm = new Form_MainMenu();
            frmMm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            product_ItemTableAdapter.FillByName(groupWst27DataSet.Product_Item, txtProductSearch.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product_ItemTableAdapter.UpdateQuantity(int.Parse(txtQuantity.Text),int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),txtDescription.Text);
            product_ItemTableAdapter.Fill(groupWst27DataSet.Product_Item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product_ItemTableAdapter.DeleteByDescription(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), txtDescription.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            product_ItemTableAdapter.Fill(groupWst27DataSet.Product_Item);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            product_ItemTableAdapter.InsertProduct(txtDescription.Text, decimal.Parse(txtPrice.Text), int.Parse(txtQuantity.Text),txtCategory.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Add order to the business stock
        private void button6_Click(object sender, EventArgs e)
        {
            //Convert.ToDecimal(dataGridView2.CurrentRow.Cells[3].Value)
            if(dataGridView2.CurrentRow.Cells[6].Value != null)
            {
                string status = dataGridView2.CurrentRow.Cells[6].Value.ToString();
               
                newStatus = "Delivered";
                decimal price = decimal.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString());
                stockTableAdapter.Insert(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), dataGridView2.CurrentRow.Cells[3].Value.ToString(),
                                         price, Convert.ToInt32(dataGridView2.CurrentRow.Cells[5].Value),
                                         DateTime.Now);
                newStatus = dataGridView2.CurrentRow.Cells[6].Value.ToString();

            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                   }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridView3.Rows.Delete();
            groupWst27DataSet1.Stock.Rows[dataGridView3.CurrentRow.Index].Delete();
            stockTableAdapter.Fill(groupWst27DataSet.Stock);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //groupWst27DataSet.Supply_Order.Rows[dataGridView2.CurrentRow.Index].Delete();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
                    }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the clicked cell
            DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Check if the clicked cell is the one you want to update
            if (clickedCell.ColumnIndex == 1) // Assuming column index 1 is the column you want to update
            {
                // Get the new value from the cell
                string newValue = clickedCell.Value.ToString();

                // Perform the update query to update the cell value in the database
                product_ItemTableAdapter.UpdateQuantity(int.Parse(txtQuantity.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),txtDescription.Text);
                // Here, you would typically use a database connection and update the value using an SQL UPDATE statement
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDescription.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
