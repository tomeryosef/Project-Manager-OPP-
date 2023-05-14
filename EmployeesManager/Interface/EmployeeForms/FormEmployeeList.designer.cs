namespace EmployeesManager
{
    partial class FormEmployeeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeList));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.Btnexit = new System.Windows.Forms.Button();
            this.snakeCaseNamingStrategyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Exportlist = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.firstNameemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationsemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_em,
            this.firstNameemDataGridViewTextBoxColumn1,
            this.lastNameemDataGridViewTextBoxColumn1,
            this.genderemDataGridViewTextBoxColumn1,
            this.addressemDataGridViewTextBoxColumn1,
            this.qualificationsemDataGridViewTextBoxColumn1,
            this.baseSalaryemDataGridViewTextBoxColumn1,
            this.birthDateemDataGridViewTextBoxColumn1,
            this.joinDateemDataGridViewTextBoxColumn1,
            this.positionemDataGridViewTextBoxColumn1,
            this.phoneNumberemDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.employeeBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridView1.Location = new System.Drawing.Point(32, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(711, 377);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Id_em
            // 
            this.Id_em.DataPropertyName = "Id_em";
            this.Id_em.HeaderText = "Id_em";
            this.Id_em.Name = "Id_em";
            this.Id_em.Width = 66;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Silver;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(749, 92);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Silver;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(749, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAddnew.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddnew.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.ForeColor = System.Drawing.Color.Silver;
            this.btnAddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnew.Location = new System.Drawing.Point(749, 56);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(100, 30);
            this.btnAddnew.TabIndex = 6;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnexit.FlatAppearance.BorderSize = 0;
            this.Btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnexit.Image = global::EmployeesManager.Properties.Resources.Close;
            this.Btnexit.Location = new System.Drawing.Point(0, 0);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(43, 43);
            this.Btnexit.TabIndex = 3;
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Exportlist
            // 
            this.Exportlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exportlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.Exportlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exportlist.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Exportlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Exportlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.Exportlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exportlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportlist.ForeColor = System.Drawing.Color.Silver;
            this.Exportlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exportlist.Location = new System.Drawing.Point(749, 164);
            this.Exportlist.Name = "Exportlist";
            this.Exportlist.Size = new System.Drawing.Size(100, 30);
            this.Exportlist.TabIndex = 7;
            this.Exportlist.Text = "Expot List";
            this.Exportlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exportlist.UseVisualStyleBackColor = false;
            this.Exportlist.Click += new System.EventHandler(this.Exportlist_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // firstNameemDataGridViewTextBoxColumn1
            // 
            this.firstNameemDataGridViewTextBoxColumn1.DataPropertyName = "FirstName_em";
            this.firstNameemDataGridViewTextBoxColumn1.HeaderText = "FirstName_em";
            this.firstNameemDataGridViewTextBoxColumn1.Name = "firstNameemDataGridViewTextBoxColumn1";
            this.firstNameemDataGridViewTextBoxColumn1.Width = 113;
            // 
            // lastNameemDataGridViewTextBoxColumn1
            // 
            this.lastNameemDataGridViewTextBoxColumn1.DataPropertyName = "LastName_em";
            this.lastNameemDataGridViewTextBoxColumn1.HeaderText = "LastName_em";
            this.lastNameemDataGridViewTextBoxColumn1.Name = "lastNameemDataGridViewTextBoxColumn1";
            this.lastNameemDataGridViewTextBoxColumn1.Width = 113;
            // 
            // genderemDataGridViewTextBoxColumn1
            // 
            this.genderemDataGridViewTextBoxColumn1.DataPropertyName = "Gender_em";
            this.genderemDataGridViewTextBoxColumn1.HeaderText = "Gender_em";
            this.genderemDataGridViewTextBoxColumn1.Name = "genderemDataGridViewTextBoxColumn1";
            this.genderemDataGridViewTextBoxColumn1.Width = 97;
            // 
            // addressemDataGridViewTextBoxColumn1
            // 
            this.addressemDataGridViewTextBoxColumn1.DataPropertyName = "address_em";
            this.addressemDataGridViewTextBoxColumn1.HeaderText = "address_em";
            this.addressemDataGridViewTextBoxColumn1.Name = "addressemDataGridViewTextBoxColumn1";
            // 
            // qualificationsemDataGridViewTextBoxColumn1
            // 
            this.qualificationsemDataGridViewTextBoxColumn1.DataPropertyName = "Qualifications_em";
            this.qualificationsemDataGridViewTextBoxColumn1.HeaderText = "Qualifications_em";
            this.qualificationsemDataGridViewTextBoxColumn1.Name = "qualificationsemDataGridViewTextBoxColumn1";
            this.qualificationsemDataGridViewTextBoxColumn1.Width = 130;
            // 
            // baseSalaryemDataGridViewTextBoxColumn1
            // 
            this.baseSalaryemDataGridViewTextBoxColumn1.DataPropertyName = "BaseSalary_em";
            this.baseSalaryemDataGridViewTextBoxColumn1.HeaderText = "BaseSalary_em";
            this.baseSalaryemDataGridViewTextBoxColumn1.Name = "baseSalaryemDataGridViewTextBoxColumn1";
            this.baseSalaryemDataGridViewTextBoxColumn1.Width = 118;
            // 
            // birthDateemDataGridViewTextBoxColumn1
            // 
            this.birthDateemDataGridViewTextBoxColumn1.DataPropertyName = "BirthDate_em";
            this.birthDateemDataGridViewTextBoxColumn1.HeaderText = "BirthDate_em";
            this.birthDateemDataGridViewTextBoxColumn1.Name = "birthDateemDataGridViewTextBoxColumn1";
            this.birthDateemDataGridViewTextBoxColumn1.Width = 107;
            // 
            // joinDateemDataGridViewTextBoxColumn1
            // 
            this.joinDateemDataGridViewTextBoxColumn1.DataPropertyName = "JoinDate_em";
            this.joinDateemDataGridViewTextBoxColumn1.HeaderText = "JoinDate_em";
            this.joinDateemDataGridViewTextBoxColumn1.Name = "joinDateemDataGridViewTextBoxColumn1";
            this.joinDateemDataGridViewTextBoxColumn1.Width = 105;
            // 
            // positionemDataGridViewTextBoxColumn1
            // 
            this.positionemDataGridViewTextBoxColumn1.DataPropertyName = "Position_em";
            this.positionemDataGridViewTextBoxColumn1.HeaderText = "Position_em";
            this.positionemDataGridViewTextBoxColumn1.Name = "positionemDataGridViewTextBoxColumn1";
            // 
            // phoneNumberemDataGridViewTextBoxColumn1
            // 
            this.phoneNumberemDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber_em";
            this.phoneNumberemDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber_em";
            this.phoneNumberemDataGridViewTextBoxColumn1.Name = "phoneNumberemDataGridViewTextBoxColumn1";
            this.phoneNumberemDataGridViewTextBoxColumn1.Width = 137;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(EmployeesManager.Employee);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(EmployeesManager.Employee);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.Exportlist);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployeeList";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btnexit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.BindingSource snakeCaseNamingStrategyBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationsemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalaryemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn houroutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteoutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button Exportlist;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}