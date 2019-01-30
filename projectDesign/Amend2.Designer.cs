namespace projectDesign
{
    partial class Amend2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAmend = new System.Windows.Forms.DataGridView();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyDataSet = new projectDesign.keyDataSet();
            this.masterTableAdapter = new projectDesign.keyDataSetTableAdapters.MasterTableAdapter();
            this.tableAdapterManager = new projectDesign.keyDataSetTableAdapters.TableAdapterManager();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.master2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master2TableAdapter = new projectDesign.keyDataSetTableAdapters.Master2TableAdapter();
            this.master1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master1TableAdapter = new projectDesign.keyDataSetTableAdapters.Master1TableAdapter();
            this.uniqueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search in the database";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(811, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(85, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAmend
            // 
            this.dgvAmend.AutoGenerateColumns = false;
            this.dgvAmend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniqueIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.allocatedDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.timeTakenDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dgvAmend.DataSource = this.master1BindingSource;
            this.dgvAmend.Location = new System.Drawing.Point(166, 56);
            this.dgvAmend.Name = "dgvAmend";
            this.dgvAmend.Size = new System.Drawing.Size(647, 394);
            this.dgvAmend.TabIndex = 17;
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(85, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // master2BindingSource
            // 
            this.master2BindingSource.DataMember = "Master2";
            this.master2BindingSource.DataSource = this.keyDataSet;
            // 
            // master2TableAdapter
            // 
            this.master2TableAdapter.ClearBeforeFill = true;
            // 
            // master1BindingSource
            // 
            this.master1BindingSource.DataMember = "Master1";
            this.master1BindingSource.DataSource = this.keyDataSet;
            // 
            // master1TableAdapter
            // 
            this.master1TableAdapter.ClearBeforeFill = true;
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
            // Amend2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 521);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvAmend);
            this.Name = "Amend2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allocate Key";
            this.Load += new System.EventHandler(this.Amend2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAmend;
        private keyDataSet keyDataSet;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private keyDataSetTableAdapters.MasterTableAdapter masterTableAdapter;
        private keyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource master2BindingSource;
        private keyDataSetTableAdapters.Master2TableAdapter master2TableAdapter;
        private System.Windows.Forms.BindingSource master1BindingSource;
        private keyDataSetTableAdapters.Master1TableAdapter master1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}