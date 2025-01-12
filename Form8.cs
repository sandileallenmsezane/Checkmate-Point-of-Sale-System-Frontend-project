
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckmateAppFinal
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst27DataSet.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.groupWst27DataSet.Sale);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Order_Item' table. You can move, or remove it, as needed.
            this.order_ItemTableAdapter.Fill(this.groupWst27DataSet.Order_Item);
            // TODO: This line of code loads data into the 'groupWst27DataSet.Product_Item' table. You can move, or remove it, as needed.
            this.product_ItemTableAdapter.Fill(this.groupWst27DataSet.Product_Item);

            //Report for Stock Level 
            SqlConnection con1 = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst27;User ID=GroupWst27;Password=mhfd5");
            SqlCommand command1 = new SqlCommand("Select * from Product_Item", con1);
            SqlDataAdapter sd1 = new SqlDataAdapter(command1);
            DataSet s1 = new DataSet();
            sd1.Fill(s1);

            StockLevel sr = new StockLevel();
            sr.SetDataSource(s1.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;

            //Report for Busiest Day of the  Week
            SqlConnection con3 = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst27;User ID=GroupWst27;Password=mhfd5");
            SqlCommand command3 = new SqlCommand("Select * from Sale", con3);
            SqlDataAdapter sd3 = new SqlDataAdapter(command3);
            DataSet s3 = new DataSet();
            sd3.Fill(s3);

            Day_Time sr1 = new Day_Time();
            sr1.SetDataSource(s3.Tables["table"]);
            crystalReportViewer2.ReportSource = sr1;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainMenu frmMm = new Form_MainMenu();
            frmMm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst27;User ID=GroupWst27;Password=mhfd5");
            SqlCommand command = new SqlCommand("Select * from Product_Item", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataSet s = new DataSet();
            sd.Fill(s);

            StockLevel sr = new StockLevel();
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dFrom = DateTime.Parse(dateTimePicker1.Text);
            DateTime dend = DateTime.Parse(dateTimePicker2.Text);
            SqlConnection con2 = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst27;User ID=GroupWst27;Password=mhfd5");
            SqlCommand command2 = new SqlCommand("Select * from Sale  where Sale_Date >= '" + dFrom + "'and Sale_Date <= '" + dend + "'", con2);
            SqlDataAdapter sd2 = new SqlDataAdapter(command2);
            DataSet s2 = new DataSet();
            sd2.Fill(s2);
            //;

            Day_Time sr = new Day_Time();
            sr.SetDataSource(s2.Tables["table"]);
            crystalReportViewer2.ReportSource = sr;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst27;User ID=GroupWst27;Password=mhfd5");
            SqlCommand command1 = new SqlCommand("Select * from Order_Item", con1);
            SqlDataAdapter sd1 = new SqlDataAdapter(command1);
            DataSet s1 = new DataSet();
            sd1.Fill(s1);

            PopularProduct sr3 = new PopularProduct();
            sr3.SetDataSource(s1.Tables["table"]);
            crystalReportViewer3.ReportSource = sr3;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_MainMenu frm2 = new Form_MainMenu();
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
