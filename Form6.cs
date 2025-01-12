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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.Fill(groupWst27DataSet.Supplier);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.DeleteSup(textBox7.Text, textBox6.Text, textBox5.Text, textBox1.Text);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.groupWst27DataSet1.Supplier);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.groupWst27DataSet.Supplier);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.UpdateSup(textBox1.Text, textBox6.Text, textBox5.Text, textBox7.Text, int.Parse(textBox2.Text));
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.AddSup(textBox7.Text, textBox6.Text, textBox5.Text, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainMenu frmMm = new Form_MainMenu();
            frmMm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
