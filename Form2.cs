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
    public partial class Form_MainMenu : Form
    {
        public string textFromFORM1{ get; set; }
        
        public Form_MainMenu()
        {
            InitializeComponent();
            
        }

        public void FormSetup(Form myForm)
        {
            foreach(Form c in this.MdiChildren)
            {
                c.Close();
            }
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();

            this.LayoutMdi(MdiLayout.Cascade);
            myForm.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if(Application.OpenForms.Count > 1)
             {
                 Form4 frm4 = (Form4)Application.OpenForms["Form4"];
                 frm4.Show();
             }
             else
             {
                 Form4 form4 = new Form4();
                 form4.Show();


             }*/
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            label2.Text = "@" + textFromFORM1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frmSix = new Form6();
            frmSix.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
        }
    }
}
