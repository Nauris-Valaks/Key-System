using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDesign
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }
        private void Register_Load(object sender, EventArgs e)
        {
            
           
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }

        private void amendDatabaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            (new Amend()).Show();
            this.Hide();

        }

        private void addToDatabaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Addcs()).Show();
            this.Hide();
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtForename.Text == String.Empty || txtPassword.Text == String.Empty || txtSurname.Text == String.Empty || txtUsername.Text == String.Empty)
            {
                MessageBox.Show("All Fields Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                LoginsDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter =
                                  new LoginsDataSetTableAdapters.AccountsTableAdapter();              


                string Forename = txtForename.Text;
                string Surname = txtSurname.Text;
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                             

                accountsTableAdapter.Insert(Forename, Surname, Username, Password);

            }
        }

        private void allocateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Allocate_Key()).Show();
            this.Hide();
        }
    }
}
