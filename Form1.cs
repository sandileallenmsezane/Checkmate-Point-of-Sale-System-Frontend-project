using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CheckmateAppFinal
{
    public partial class Form1 : Form
    {
        String username, userpassword;
        public Form1()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(135, Color.Black);
            //txtUserName.BackColor = Color.FromArgb(135, Color.Black);
            //txtPassword.BackColor = Color.FromArgb(135, Color.Black);

        }

        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst27;User ID=GroupWst27;Password=mhfd5");


        Form_MainMenu f2 = new Form_MainMenu();
        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {

            /* Boolean found = false;
            foreach (var dr in dataSet1.Employee)
             {
                 if (dr.FirstName == txtUserName.Text && dr.Password == txtPassword.Text)
                 {
                     found = true;
                     Form frm = (Form)Application.OpenForms["Form_MainMenu"];
                     this.Hide();
                     Form_MainMenu fMainMenu = new Form_MainMenu();
                     fMainMenu.ShowDialog();
                    // MessageBox.Show("WELCOME User!! " + txtUserName.Text);

                     break;
                 }

             }
                 if (!(found))
                 MessageBox.Show("Invalid UserName or Password!");
                // this.Close();*/


            
            username = txtUserName.Text;
            userpassword = txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM Employee WHERE FirstName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    userpassword = txtPassword.Text;

                    //page that has to load next
                    Form_MainMenu form1 = new Form_MainMenu();
                    form1.textFromFORM1 = txtUserName.Text;
                    form1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();

                    //to focus username
                    txtUserName.Focus();
                }

            }
            catch
            {
                MessageBox.Show("invalid login");
            }
            finally
            {
                conn.Close();
            }

            //Form_MainMenu fr = new Form_MainMenu();
            

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Gray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.ForeColor = Color.Aqua;
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Aqua;
            txtPassword.Clear();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                Form_MainMenu frmMm = new Form_MainMenu();
                frmMm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
