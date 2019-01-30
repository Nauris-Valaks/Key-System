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
using System.Data.OleDb;

namespace projectDesign
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        User login = new User("user", "1234");

        Admin admin = new Admin("admin", "1234");
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string adminuser = txtUsername.Text;
            string adminpass = txtPassword.Text;

            //check if eligible to be logged in 
            if (admin.IsLoggedIn(adminuser, adminpass))
            {
                MessageBox.Show("You are logged in successfully");
                this.Visible = false;
                (new Allocate_Key()).Show();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
                this.Visible = false;
                (new Amend2()).Show();

            }

        }







            //string user = txtUsername.Text;
            //string pass = txtPassword.Text;

            //if (login.IsLoggedIn(user, pass))
            //{
            //    MessageBox.Show("You are logged in successfully");
            //    this.Visible = false;
            //    (new Allocate_Key()).Show();

            //}


        }
    }
            



