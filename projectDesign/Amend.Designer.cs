namespace projectDesign
{
    partial class Amend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAmend = new System.Windows.Forms.DataGridView();
            this.uniqueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyDataSet = new projectDesign.keyDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.masterTableAdapter = new projectDesign.keyDataSetTableAdapters.MasterTableAdapter();
            this.tableAdapterManager = new projectDesign.keyDataSetTableAdapters.TableAdapterManager();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allocateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAmend
            // 
            this.dgvAmend.AutoGenerateColumns = false;
            this.dgvAmend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniqueIDDataGridViewTextBoxColumn,
            this.keyNoDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.allocatedDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.timeTakenDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.spareDataGridViewCheckBoxColumn});
            this.dgvAmend.DataSource = this.masterBindingSource;
            this.dgvAmend.Location = new System.Drawing.Point(171, 53);
            this.dgvAmend.Name = "dgvAmend";
            this.dgvAmend.Size = new System.Drawing.Size(846, 450);
            this.dgvAmend.TabIndex = 0;
            // 
            // uniqueIDDataGridViewTextBoxColumn
            // 
            this.uniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID";
            this.uniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID";
            this.uniqueIDDataGridViewTextBoxColumn.Name = "uniqueIDDataGridViewTextBoxColumn";
            // 
            // keyNoDataGridViewTextBoxColumn
            // 
            this.keyNoDataGridViewTextBoxColumn.DataPropertyName = "KeyNo";
            this.keyNoDataGridViewTextBoxColumn.HeaderText = "KeyNo";
            this.keyNoDataGridViewTextBoxColumn.Name = "keyNoDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // allocatedDataGridViewTextBoxColumn
            // 
            this.allocatedDataGridViewTextBoxColumn.DataPropertyName = "Allocated";
            this.allocatedDataGridViewTextBoxColumn.HeaderText = "Allocated";
            this.allocatedDataGridViewTextBoxColumn.Name = "allocatedDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // timeTakenDataGridViewTextBoxColumn
            // 
            this.timeTakenDataGridViewTextBoxColumn.DataPropertyName = "Time Taken";
            this.timeTakenDataGridViewTextBoxColumn.HeaderText = "Time Taken";
            this.timeTakenDataGridViewTextBoxColumn.Name = "timeTakenDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // spareDataGridViewCheckBoxColumn
            // 
            this.spareDataGridViewCheckBoxColumn.DataPropertyName = "Spare";
            this.spareDataGridViewCheckBoxColumn.HeaderText = "Spare";
            this.spareDataGridViewCheckBoxColumn.Name = "spareDataGridViewCheckBoxColumn";
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Master";
            this.masterBindingSource.DataSource = this.keyDataSet;
            // 
            // keyDataSet
            // 
            this.keyDataSet.DataSetName = "keyDataSet";
            this.keyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(90, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 27);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeleteToolStripMenuItem,
            this.addUsersToolStripMenuItem,
            this.allocateKeyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addDeleteToolStripMenuItem
            // 
            this.addDeleteToolStripMenuItem.Name = "addDeleteToolStripMenuItem";
            this.addDeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDeleteToolStripMenuItem.Text = "Add New Key";
            this.addDeleteToolStripMenuItem.Click += new System.EventHandler(this.addDeleteToolStripMenuItem_Click);
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUsersToolStripMenuItem.Text = "Add users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1089, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // masterTableAdapter
            // 
            this.masterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Master1TableAdapter = null;
            this.tableAdapterManager.Master2TableAdapter = null;
            this.tableAdapterManager.MasterTableAdapter = this.masterTableAdapter;
            this.tableAdapterManager.UpdateOrder = projectDesign.keyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(90, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1023, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search in the database";
            // 
            // allocateKeyToolStripMenuItem
            // 
            this.allocateKeyToolStripMenuItem.Name = "allocateKeyToolStripMenuItem";
            this.allocateKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allocateKeyToolStripMenuItem.Text = "Allocate Key";
            // 
            // Amend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAmend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Amend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Database";
            this.Load += new System.EventHandler(this.Amend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmend;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private keyDataSet keyDataSet;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private keyDataSetTableAdapters.MasterTableAdapter masterTableAdapter;
        private keyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn spareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem allocateKeyToolStripMenuItem;
    }
}