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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.groupWst27DataSet.Employee);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Employee' table. You can move, or remove it, as needed.


        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainMenu frmMm = new Form_MainMenu();
            frmMm.ShowDialog();
        }

      
        private void button12_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.AddEmployer(textBox7.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox8.Text);
            employeeTableAdapter.Fill(groupWst27DataSet.Employee);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.UpdateQuery(textBox7.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox8.Text, int.Parse(textBox9.Text));
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //textBox9.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if(result == DialogResult.Yes)
            {
                employeeTableAdapter.DeleteStaff(int.Parse(textBox9.Text), textBox7.Text, textBox6.Text, textBox5.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox8.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                employeeTableAdapter.Fill(groupWst27DataSet.Employee);
            }
            else
            {
                
            }
            
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox9.ForeColor = Color.Black;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
           
        }
    }
}
