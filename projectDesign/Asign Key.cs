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
    public partial class Allocate_Key : Form
    {
        public Allocate_Key()
        {
            InitializeComponent();
        }

        private void Asign_Key_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyDataSet.Master' table. You can move, or remove it, as needed.
            this.master1TableAdapter.Fill(this.keyDataSet.Master1);
  

        }

        private void amendDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Amend()).Show();
            this.Hide();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Register()).Show();
            this.Hide();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.master1BindingSource.EndEdit();
                this.master1TableAdapter.Update(this.keyDataSet.Master1);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            dgvAllocate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgvAllocate.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgvAllocate.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtSearch.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(dgvAllocate.DataSource);
            (dgvAllocate.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", txtSearch.Text);
        }

        private void dgvAmend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Addcs()).Show();
            this.Hide();
        }
    }
}
