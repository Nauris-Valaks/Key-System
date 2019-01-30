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
    public partial class Addcs : Form
    {
        public Addcs()
        {
            InitializeComponent();
        }

        private void Addcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyDataSet.Master2' table. You can move, or remove it, as needed.
            this.master2TableAdapter.Fill(this.keyDataSet.Master2);

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void amendDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Amend()).Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Register()).Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                {


                    keyDataSetTableAdapters.Master2TableAdapter master2TableAdapter =
                                       new keyDataSetTableAdapters.Master2TableAdapter();


                    string KeyNo = txtKeyNo.Text;
                    string Type = txtType.Text;
                    string Location = txtLocation.Text;
                    bool Spare = cbSpare.Checked;




                    master2TableAdapter.Insert(KeyNo, Type, Location,  Spare);

                    this.Validate();
                    this.master2BindingSource.EndEdit();
                    this.master2TableAdapter.Update(this.keyDataSet.Master2);
                    this.master2TableAdapter.Fill(this.keyDataSet.Master2);
                    this.Refresh();

                }
            }
            catch (Exception ex) // catches the error thrown and displays an error message after
            {
                MessageBox.Show("Error"); // error message which will display once an error is catched
            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adding ");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void asignKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Allocate_Key()).Show();
            this.Hide();
        }
    }
}
