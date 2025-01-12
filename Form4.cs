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
    public partial class Form4 : Form
    {
        Form7 form7 = new Form7();
        string itemQuantity, itemName, itemPrice, itemTotal;
        public int saleId = 0;
        

        public Form4()
        {
            

            InitializeComponent();
            //Add a CheckBox Column to the DataGridView at the first position.
            /* DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
             checkBoxColumn.HeaderText = "";
             checkBoxColumn.Width = 30;
             checkBoxColumn.Name = "checkBoxColumn";
             dataGridView1.Columns.Insert(0, checkBoxColumn);*/

           
        }

        public DataGridView GetDataGridView()
        {
            return dataGridView2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'groupWst27DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst27DataSet.Customer);
            // TODO: This line of code loads data into the 'groupWst27DataSet.SALE_ITEM' table. You can move, or remove it, as needed.
            //this.sALE_ITEMTableAdapter.Fill(this.groupWst27DataSet.SALE_ITEM);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Product_Item' table. You can move, or remove it, as needed.
            this.product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);
            //ThreshholdProducts();
            

        }

        public void ThreshholdProducts()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) <= 5)
                {
                    MessageBox.Show("Your product is running low", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            try
            {
                if (textBox5.Text != null)
                {
                    String price = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    double value = double.Parse(price) * 0.15;
                    DataRow dr;
                    dr = groupWst27DataSet.SALE_ITEM.NewRow();

                    dr[0] = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    dr[1] = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dr[2] = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dr[3] = value.ToString();
                    dr[4] = textBox5.Text;

                    groupWst27DataSet.SALE_ITEM.Rows.Add(dr);
                }
              
            }catch
            {
                MessageBox.Show(" Insert Quantity");
            }
            
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Add)
            {
                textBox5.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
           


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //the method below ask if its anew customer or old
        public bool isEmpty(string text)
        {
            if(text == "ID")
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmpty(customerID.Text) == true)
                {
                    DialogResult rs = MessageBox.Show("Add this Customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        MessageBox.Show("Press the Button [Manage Customers] to Add the Customer");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    tabControl1.SelectedTab = tabPage2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Elert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
              

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                   }
        private void AddItemToListBox(string item)
        {
           
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define the position and layout of the slip
            int startX = 10;
            int startY = 10;
            int lineHeight = 20;

            // Create a font for the slip content
            Font font = new Font("Arial", 12);

            // Loop through DataGridView rows and print the data
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[4].Value != null)
                {
                    string product = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    string description = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    string price = dataGridView2.Rows[i].Cells[3].Value.ToString();

                    string line = $"{product} - {description} -         {price}";

                    e.Graphics.DrawString(line, font, Brushes.Black, startX, startY + i * lineHeight);
                }
                
            }
        }

        public double totalAm(int qua,double price)
        {
            return price * qua;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            // Trigger the print process when a button (e.g., PrintButton) is clicked
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();

            //This verifies if tthe customer is using card or payment
            // Display a confirmation message box

            saleId += 1;
            Form10 for10 = new Form10();

                DialogResult results = MessageBox.Show("Cash Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (results == DialogResult.Yes && ptype.Text != null)
            {
                Form10 fr10 = new Form10();
                Form7 form7 = new Form7();
                ptype.Text = "Cash";
                form7.Payment.Text = "Cash";
                form7.label7.Text = saleId.ToString();
                ptype.ForeColor = Color.Transparent;

                fr10.saleTableAdapter.Insert(Convert.ToInt32(custIdL.Text), Convert.ToDecimal(textBox2.Text),
                           DateTime.Now, ptype.Text);

                for10.saleTableAdapter.Fill(groupWst27DataSet.Sale);

                if (fr10.dataGridView3.CurrentRow != null &&
    fr10.dataGridView3.CurrentRow.Cells[0] != null &&
    fr10.dataGridView3.CurrentRow.Cells[0].Value != null)
                {
                    MessageBox.Show("Not Null");
                }

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    Form10 frm10 = new Form10();
                    Form7 f7 = new Form7();

                    
                    if (dataGridView2.Rows[i].Cells[4].Value != null && f7.textBox2.Text != null)
                    {

                        if (dataGridView2.Rows[i].Cells[4].Value != null)
                        {
                           
                            fr10.order_ItemTableAdapter.Insert(Convert.ToInt32(custIdL.Text), Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value)
                                , dataGridView2.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value), Convert.ToDecimal(totalAm(Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value),Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value))),
                                DateTime.Today);


                        }

                    }
                }
                



                Form10 f10 = new Form10();
                String total = textBox2.Text;
                int itemsNo = 0;

                Form7 for7 = new Form7();
                //ListBox listBox = form7.listBox1;
                RichTextBox receiptText1 = form7.txtSlip;
                form7.textBox4.Text = total;


                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    try
                    {


                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            Form7 f7 = new Form7();
                            if (dataGridView2.Rows[i].Cells[4].Value != null)
                            {
                                product_ItemTableAdapter.UpdateElert(int.Parse(textBox5.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                                if (dataGridView2.Rows[i].Cells[4].Value != null)
                                {

                                }

                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("the sale item is null!!!");

                    }
                    //DialogResult ds = MessageBox.Show("Print Reciept?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("The Order Amount of " + textBox2.Text + " Has Been Added");

                    string amount = form7.textBox4.Text;
                    string custID = "ID :" + custIdL.Text;
                    double Amount = 0;

                    // Clear the receiptRichTextBox before generating the receipt
                    //form7.txtSlip.Clear();

                    // Create a StringBuilder to build the receipt text
                    StringBuilder receiptText = new StringBuilder();

                    // Add header to the receipt
                    receiptText.AppendLine("===== Shopping Receipt =====");
                    receiptText.AppendLine($"Customer No: {custIdL.Text}");
                    receiptText.AppendLine($"Date: {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}");
                    receiptText.AppendLine();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {

                        if (!row.IsNewRow)
                        {


                            string itemName = row.Cells[1].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells[4].Value);
                            decimal price = Convert.ToDecimal(row.Cells[3].Value);
                            decimal total2 = quantity * price;

                            receiptText.AppendLine($"Item: {itemName}");
                            receiptText.AppendLine($"Quantity: {quantity}");
                            receiptText.AppendLine($"Price per unit: R{price:F2}");
                            receiptText.AppendLine($"Total cost: R{total2:F2}");
                            receiptText.AppendLine();

                        }

                    }
                    // Add footer and total to the receipt
                    receiptText.AppendLine("============================");
                    receiptText.AppendLine($"Total Amount: R{textBox2.Text:F2}");
                    
                    receiptText.AppendLine("Thank you for shopping with us!");

                    form7.txtSlip.Text = receiptText.ToString();

                    

                    form7.textBox1.Text = itemsNo.ToString();

                    form7.Show();


                    this.Hide();
                    //Form7 frmSev = new Form7();
                    //frmSev.ShowDialog();

                    //decimal Total = decimal.Parse(textBox2.Text);
                    decimal noOfitems = 0;

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[4].Value != null)
                        {
                            noOfitems += decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                        }
                    }
                    form7.textBox1.Text = noOfitems.ToString();
                }
            }
                else
                {
                    Form7 form71 = new Form7();

                    ptype.Text = "Card";
                    form71.Payment.Text = "Card";
                    ptype.ForeColor = Color.Transparent;

                for10.saleTableAdapter.Insert(Convert.ToInt32(custIdL.Text), Convert.ToDecimal(textBox2.Text),
                          DateTime.Now, form71.Payment.Text);

                for10.saleTableAdapter.Fill(groupWst27DataSet.Sale);


                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                 {
                 Form10 frm10 = new Form10();
                     Form7 f7 = new Form7();
                     if (dataGridView2.Rows[i].Cells[4].Value != null && f7.textBox2.Text != null)
                     {
                         if (dataGridView2.Rows[i].Cells[4].Value != null)
                         {
                            
                            for10.order_ItemTableAdapter.Insert(Convert.ToInt32(custIdL.Text), Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value)
                                , dataGridView2.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value), Convert.ToDecimal(totalAm(Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value))),
                                DateTime.Now);


                        }

                     }
                 }
               
                Form10 f10 = new Form10();
                String total = textBox2.Text;
                int itemsNo = 0;

                Form7 form7 = new Form7();
                //ListBox listBox = form7.listBox1;
                RichTextBox recieptText = form7.txtSlip;
                form7.textBox4.Text = total;                



                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {


                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            Form7 f7 = new Form7();
                            if (dataGridView2.Rows[i].Cells[4].Value != null)
                            {
                                product_ItemTableAdapter.UpdateElert(int.Parse(textBox5.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                                if (dataGridView2.Rows[i].Cells[4].Value != null)
                                {

                                }

                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("the sale item is null!!!");

                    }
                   

                    MessageBox.Show("The Order Amount " + textBox2.Text + " Has Been Added");
                    string amount = form7.textBox4.Text;
                    string custID = "ID :" + custIdL.Text;
                    // Clear the receiptRichTextBox before generating the receipt
                    //form7.txtSlip.Clear();

                    // Create a StringBuilder to build the receipt text
                    StringBuilder receiptText = new StringBuilder();

                    // Add header to the receipt
                    receiptText.AppendLine("===== Shopping Receipt =====");
                    receiptText.AppendLine($"Customer No: {custIdL.Text}");
                    receiptText.AppendLine($"Date: {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}");
                    receiptText.AppendLine();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {

                        if (!row.IsNewRow)
                        {


                            string itemName = row.Cells[1].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells[4].Value);
                            decimal price = Convert.ToDecimal(row.Cells[3].Value);
                            decimal total1 = quantity * price;

                            receiptText.AppendLine($"Item: {itemName}");
                            receiptText.AppendLine($"Quantity: {quantity}");
                            receiptText.AppendLine($"Price per unit: R{price:F2}");
                            receiptText.AppendLine($"Total cost: R{total1:F2}");
                            receiptText.AppendLine();

                            
                        }

                    }
                    // Add footer and total to the receipt
                    receiptText.AppendLine("============================");
                    receiptText.AppendLine($"Total Amount: R{textBox2.Text:F2}");
                    receiptText.AppendLine("Thank you for shopping with us!");

                    // Display the receipt in the richTextBox
                    form7.txtSlip.Text = receiptText.ToString();


                    form7.textBox1.Text = itemsNo.ToString();

                    form7.Show();


                    this.Hide();
                    //Form7 frmSev = new Form7();
                    //frmSev.ShowDialog();

                    //decimal Total = decimal.Parse(textBox2.Text);
                    decimal noOfitems = 0;

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[4].Value != null)
                        {
                            noOfitems += decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                        }
                    }
                    form7.textBox1.Text = noOfitems.ToString();
                }
            }


            product_ItemTableAdapter.Fill(groupWst27DataSet.Product_Item);

        }
        //Calculate with Vat
        private void button6_Click_1(object sender, EventArgs e)
        {
            //generate the total Amount Due
            decimal TotalAmount = 0;
            decimal subTotal;
            decimal rate = 15 / 100;//rate of tax
            decimal VAT = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[4].Value != null)
                {
                    product_ItemTableAdapter.UpdateElert(int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString()) ,int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()));
                    VAT += decimal.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()) * decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                }
                product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);
            }
            

            textBox3.Text = VAT.ToString("C");
            if(textBox1.Text == " ")
            {
                subTotal = 0;
                TotalAmount = subTotal + VAT;
                textBox2.Text = TotalAmount.ToString();
            }
            subTotal = decimal.Parse(textBox1.Text);
            TotalAmount = subTotal + VAT;
            textBox2.Text = TotalAmount.ToString();
        }

        // Calculate the total amount from dataGridView1
        private decimal CalculateTotalAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int quantity = Convert.ToInt32(row.Cells[4].Value);
                    decimal price = Convert.ToDecimal(row.Cells[3].Value);
                    decimal itemTotal = quantity * price;
                    total += itemTotal;
                }
            }

            return total;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            product_ItemTableAdapter.FillByName(groupWst27DataSet.Product_Item, textBox4.Text);
            //product_ItemTableAdapter.Fill(groupWst27DataSet.Product_Item); 
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            groupWst27DataSet.SALE_ITEM.Rows.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal OrderTotal = 0;
                int QauntityAvailable = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                int QuantityBought = int.Parse(textBox5.Text);

                if (QauntityAvailable < QuantityBought)
                {
                    MessageBox.Show("You cannot sell more than " + textBox5.Text + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "s", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //product_ItemTableAdapter.UpdateElert(int.Parse(textBox5.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {


                        if (dataGridView2.Rows[i].Cells[4].Value != null)
                        {
                            OrderTotal += decimal.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) * decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                        }
                    }

                    textBox1.Text = OrderTotal.ToString();
                    product_ItemTableAdapter.UpdateElert(int.Parse(textBox5.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    this.product_ItemTableAdapter.Fill(groupWst27DataSet.Product_Item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You cannot sell more than " + textBox5.Text + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "s");   
            }
        }
        //Delete the item that was selected by mistake when purchasing
        private void button7_Click_1(object sender, EventArgs e)
        {
            //sALE_ITEMTableAdapter.DeleteProduct(int.Parse(textBox8.Text),textBox7.Text);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                
            }
            if (dataGridView2.CurrentRow.Cells[4].Value != null)
            {
                product_ItemTableAdapter.UpdateQuantity(int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString()), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), dataGridView1.CurrentRow.Cells[1].Value.ToString());
                product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);
            }


            groupWst27DataSet.SALE_ITEM.Rows[dataGridView2.CurrentRow.Index].Delete();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainMenu frmMm = new Form_MainMenu();
            frmMm.ShowDialog();
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerID.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            customerID.ForeColor = Color.Aqua;

            label11.Text = DateTime.Now.ToShortDateString();
            label11.ForeColor = Color.Aqua;

            label12.ForeColor = Color.Aqua;

            custIdL.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            custIdL.ForeColor = Color.Aqua;

            
            CustName.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView3.CurrentRow.Cells[2].Value.ToString();
            CustName.ForeColor = Color.Aqua;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //CODE below add the Selected item to Sale Item 
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (textBox5.Text != null)
                {
                    String price = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    double value = double.Parse(price) * 0.15;
                    DataRow dr;
                    dr = groupWst27DataSet.SALE_ITEM.NewRow();

                    dr[0] = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    dr[1] = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dr[2] = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dr[3] = value.ToString();
                    dr[4] = textBox5.Text;

                    

                    groupWst27DataSet.SALE_ITEM.Rows.Add(dr);
                    //product_ItemTableAdapter.UpdateElert(int.Parse(textBox5.Text), int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);

                    //DataRow dr2;
                    //dr2 = groupWst27DataSet.Product_Item.NewRow();


                }

            }
            catch
            {
                MessageBox.Show(" Insert Quantity");
            }

            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillByName(groupWst27DataSet.Customer, textBox9.Text);

        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox9.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(groupWst27DataSet.Customer);
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            custIdL.Text = "Cust ID";
            customerID.Text = "ID";
            label11.Text = " ";
            CustName.Text = " ";
            tabControl1.SelectedTab = tabPage1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
