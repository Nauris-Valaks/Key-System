namespace projectDesign
{
    partial class Addcs
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.amendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.keyDataSet = new projectDesign.keyDataSet();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterTableAdapter = new projectDesign.keyDataSetTableAdapters.MasterTableAdapter();
            this.tableAdapterManager = new projectDesign.keyDataSetTableAdapters.TableAdapterManager();
            this.cbSpare = new System.Windows.Forms.CheckBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.master2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.master1TableAdapter = new projectDesign.keyDataSetTableAdapters.Master1TableAdapter();
            this.lbType = new System.Windows.Forms.Label();
            this.lbKeyNo = new System.Windows.Forms.Label();
            this.txtKeyNo = new System.Windows.Forms.TextBox();
            this.master2TableAdapter = new projectDesign.keyDataSetTableAdapters.Master2TableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(6, 27);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amendToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // amendToolStripMenuItem
            // 
            this.amendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amendDetailsToolStripMenuItem,
            this.addUsersToolStripMenuItem,
            this.asignKeyToolStripMenuItem});
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
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addUsersToolStripMenuItem.Text = "Add user";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // asignKeyToolStripMenuItem
            // 
            this.asignKeyToolStripMenuItem.Name = "asignKeyToolStripMenuItem";
            this.asignKeyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.asignKeyToolStripMenuItem.Text = "Allocate Key";
            this.asignKeyToolStripMenuItem.Click += new System.EventHandler(this.asignKeyToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1025, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // keyDataSet
            // 
            this.keyDataSet.DataSetName = "keyDataSet";
            this.keyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Master1TableAdapter = null;
            this.tableAdapterManager.Master2TableAdapter = null;
            this.tableAdapterManager.MasterTableAdapter = this.masterTableAdapter;
            this.tableAdapterManager.UpdateOrder = projectDesign.keyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbSpare
            // 
            this.cbSpare.AutoSize = true;
            this.cbSpare.Location = new System.Drawing.Point(148, 184);
            this.cbSpare.Name = "cbSpare";
            this.cbSpare.Size = new System.Drawing.Size(54, 17);
            this.cbSpare.TabIndex = 38;
            this.cbSpare.Text = "Spare";
            this.cbSpare.UseVisualStyleBackColor = true;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(48, 158);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(48, 13);
            this.lbLocation.TabIndex = 33;
            this.lbLocation.Text = "Location";
            // 
            // dgvAdd
            // 
            this.dgvAdd.AutoGenerateColumns = false;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.locationDataGridViewTextBoxColumn,
            this.spareDataGridViewCheckBoxColumn});
            this.dgvAdd.DataSource = this.master2BindingSource;
            this.dgvAdd.Location = new System.Drawing.Point(238, 74);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.Size = new System.Drawing.Size(545, 372);
            this.dgvAdd.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UniqueID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UniqueID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KeyNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "KeyNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // spareDataGridViewCheckBoxColumn
            // 
            this.spareDataGridViewCheckBoxColumn.DataPropertyName = "Spare";
            this.spareDataGridViewCheckBoxColumn.HeaderText = "Spare";
            this.spareDataGridViewCheckBoxColumn.Name = "spareDataGridViewCheckBoxColumn";
            // 
            // master2BindingSource
            // 
            this.master2BindingSource.DataMember = "Master2";
            this.master2BindingSource.DataSource = this.keyDataSet;
            // 
            // master1BindingSource
            // 
            this.master1BindingSource.DataMember = "Master1";
            this.master1BindingSource.DataSource = this.keyDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(102, 132);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 28;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(102, 158);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 26;
            // 
            // master1TableAdapter
            // 
            this.master1TableAdapter.ClearBeforeFill = true;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(57, 132);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 34;
            this.lbType.Text = "Type";
            // 
            // lbKeyNo
            // 
            this.lbKeyNo.AutoSize = true;
            this.lbKeyNo.Location = new System.Drawing.Point(49, 106);
            this.lbKeyNo.Name = "lbKeyNo";
            this.lbKeyNo.Size = new System.Drawing.Size(39, 13);
            this.lbKeyNo.TabIndex = 31;
            this.lbKeyNo.Text = "KeyNo";
            // 
            // txtKeyNo
            // 
            this.txtKeyNo.Location = new System.Drawing.Point(102, 106);
            this.txtKeyNo.Name = "txtKeyNo";
            this.txtKeyNo.Size = new System.Drawing.Size(100, 20);
            this.txtKeyNo.TabIndex = 25;
            // 
            // master2TableAdapter
            // 
            this.master2TableAdapter.ClearBeforeFill = true;
            // 
            // Addcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 531);
            this.Controls.Add(this.cbSpare);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbKeyNo);
            this.Controls.Add(this.dgvAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtKeyNo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Addcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Key";
            this.Load += new System.EventHandler(this.Addcs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem amendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private keyDataSet keyDataSet;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private keyDataSetTableAdapters.MasterTableAdapter masterTableAdapter;
        private keyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox cbSpare;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.BindingSource master1BindingSource;
        private keyDataSetTableAdapters.Master1TableAdapter master1TableAdapter;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbKeyNo;
        private System.Windows.Forms.TextBox txtKeyNo;
        private System.Windows.Forms.ToolStripMenuItem asignKeyToolStripMenuItem;
        private System.Windows.Forms.BindingSource master2BindingSource;
        private keyDataSetTableAdapters.Master2TableAdapter master2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn spareDataGridViewCheckBoxColumn;
    }
}