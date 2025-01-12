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
    public partial class Form7 : Form
    {

        public string paymenttype;
        public Form7()
        {
            InitializeComponent();
           
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            // Assuming you want to remove data for a specific date
            DateTime dateToRemove = DateTime.Today;

            // Get the instance of Form1 (if it's already open)
            Form10 form1 = Application.OpenForms["Form10"] as Form10;

            if (form1 != null)
            {
                // Call the RemoveRowsByDate method to remove the data
                form1.RemoveRowsByDate1(dateToRemove);
                form1.RemoveRowsByDate(dateToRemove);
            }



        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet.SALE_ITEM' table. You can move, or remove it, as needed.
            this.sALE_ITEMTableAdapter.Fill(this.groupWst27DataSet.SALE_ITEM);

        }



        private void button8_Click(object sender, EventArgs e)
        {

            Form10 for10 = new Form10();


            string dataToTransfer = txtSlip.Text;

            for10.richTextBox1.Text = dataToTransfer;

            // Show Form 10
            for10.Show();

            this.Hide();
            for10.Show();
            Form4 frm4 = new Form4();

            //if (frm4.dataGridView2.CurrentRow.Cells[1].Value != null)
            //{

            //}



            Form8 frm8 = new Form8();
        }
            
           

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox4.ForeColor = Color.Black;
            try
            {
                TextBox Tb4 = textBox4;
                TextBox Tb5 = textBox5;

                decimal value1 = Decimal.Parse(Tb4.Text);
                decimal value2 = Decimal.Parse(Tb5.Text);


                if (value2 < value1)
                {
                    //MessageBox.Show("Insufficient Funds!");
                }
                else
                {

                    Payment.Text = "Cash";
                    decimal difference = value2 - value1;
                    MessageBox.Show("Change: " + difference);
                    textBox2.Text = difference.ToString();


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_MainMenu m = new Form_MainMenu();
            this.Hide();
            m.Show();

            //try
            //{
            //    TextBox Tb4 = textBox4;
            //    TextBox Tb5 = textBox5;

            //    decimal value1 = Decimal.Parse(Tb4.Text);
            //    decimal value2 = Decimal.Parse(Tb5.Text);

               
            //        if (value2 < value1)
            //        {
            //            MessageBox.Show("Insufficient Funds!");
            //        }
            //        else
            //        {

            //            Payment.Text = "Cash";
            //            decimal difference = value2 - value1;
            //            MessageBox.Show("Change: " + difference);
            //            textBox2.Text = difference.ToString();


            //        }


               
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            //}
           
        }
        private void TransferDataToForm10()
        {
            Form10 form10 = new Form10();
            List<string> listBoxData = new List<string>();

            // Retrieve data from listBox1
            /*foreach (var item in listBox1.Items)
            {
                listBoxData.Add(item.ToString());
            }*/

            // Call the LoadData method in Form10 and pass the data
            //form10.LoadData(listBoxData);

            // Show Form10
            form10.Show();
        }


        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void txtSlip_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtSlip.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            
        }

        private void txtSlip_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
