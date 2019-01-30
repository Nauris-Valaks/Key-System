namespace projectDesign
{
    partial class Allocate_Key
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.amendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAllocate = new System.Windows.Forms.DataGridView();
            this.uniqueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyDataSet = new projectDesign.keyDataSet();
            this.master1TableAdapter = new projectDesign.keyDataSetTableAdapters.Master1TableAdapter();
            this.tableAdapterManager = new projectDesign.keyDataSetTableAdapters.TableAdapterManager();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterTableAdapter = new projectDesign.keyDataSetTableAdapters.MasterTableAdapter();
            this.addNewKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(920, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 27);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 40;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amendToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // amendToolStripMenuItem
            // 
            this.amendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amendDetailsToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.addNewKeyToolStripMenuItem});
            this.amendToolStripMenuItem.Name = "amendToolStripMenuItem";
            this.amendToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.amendToolStripMenuItem.Text = "Options";
            // 
            // amendDetailsToolStripMenuItem
            // 
            this.amendDetailsToolStripMenuItem.Name = "amendDetailsToolStripMenuItem";
            this.amendDetailsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.amendDetailsToolStripMenuItem.Text = "Update Database";
            this.amendDetailsToolStripMenuItem.Click += new System.EventHandler(this.amendDetailsToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(138, 141);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(75, 23);
            this.btnAllocate.TabIndex = 49;
            this.btnAllocate.Text = "Allocate Key";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(138, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Search in the database";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(113, 115);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAllocate
            // 
            this.dgvAllocate.AutoGenerateColumns = false;
            this.dgvAllocate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniqueIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.allocatedDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.timeTakenDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dgvAllocate.DataSource = this.master1BindingSource;
            this.dgvAllocate.Location = new System.Drawing.Point(219, 39);
            this.dgvAllocate.Name = "dgvAllocate";
            this.dgvAllocate.Size = new System.Drawing.Size(647, 427);
            this.dgvAllocate.TabIndex = 53;
            this.dgvAllocate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmend_CellContentClick);
            // 
            // uniqueIDDataGridViewTextBoxColumn
            // 
            this.uniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID";
            this.uniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID";
            this.uniqueIDDataGridViewTextBoxColumn.Name = "uniqueIDDataGridViewTextBoxColumn";
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
            // master1BindingSource
            // 
            this.master1BindingSource.DataMember = "Master1";
            this.master1BindingSource.DataSource = this.keyDataSet;
            // 
            // keyDataSet
            // 
            this.keyDataSet.DataSetName = "keyDataSet";
            this.keyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // master1TableAdapter
            // 
            this.master1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Master1TableAdapter = this.master1TableAdapter;
            this.tableAdapterManager.Master2TableAdapter = null;
            this.tableAdapterManager.MasterTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projectDesign.keyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Master";
            this.masterBindingSource.DataSource = this.keyDataSet;
            // 
            // masterTableAdapter
            // 
            this.masterTableAdapter.ClearBeforeFill = true;
            // 
            // addNewKeyToolStripMenuItem
            // 
            this.addNewKeyToolStripMenuItem.Name = "addNewKeyToolStripMenuItem";
            this.addNewKeyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addNewKeyToolStripMenuItem.Text = "Add New Key";
            this.addNewKeyToolStripMenuItem.Click += new System.EventHandler(this.addNewKeyToolStripMenuItem_Click);
            // 
            // Allocate_Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 535);
            this.Controls.Add(this.dgvAllocate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Allocate_Key";
            this.Text = "Allocate Key";
            this.Load += new System.EventHandler(this.Asign_Key_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem amendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private keyDataSet keyDataSet;
        private System.Windows.Forms.BindingSource master1BindingSource;
        private keyDataSetTableAdapters.Master1TableAdapter master1TableAdapter;
        private keyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private keyDataSetTableAdapters.MasterTableAdapter masterTableAdapter;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAllocate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem addNewKeyToolStripMenuItem;
    }
}