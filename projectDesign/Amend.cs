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
    public partial class Amend : Form
    {
        public Amend()
        {
            InitializeComponent();
        }

        private void addDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Addcs()).Show();
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

        private void Amend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keyDataSet.Master' table. You can move, or remove it, as needed.
            this.masterTableAdapter.Fill(this.keyDataSet.Master);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.masterBindingSource.EndEdit();
                this.masterTableAdapter.Update(this.keyDataSet.Master);
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
            dgvAmend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgvAmend.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgvAmend.Rows[rowIndex].Selected = true;
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
            DataTable data = (DataTable)(dgvAmend.DataSource);
            (dgvAmend.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", txtSearch.Text);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            foreach(DataGridViewCell oneCell in dgvAmend.SelectedCells)
    {
                if (oneCell.Selected)
                    dgvAmend.Rows.RemoveAt(oneCell.RowIndex);

                this.Validate();
                this.masterBindingSource.EndEdit();
                this.masterTableAdapter.Update(this.keyDataSet.Master);
            }

        }
    }
}
