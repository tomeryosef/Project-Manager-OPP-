namespace EmployeesManager
{
    partial class FormPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll));
            this.label1 = new System.Windows.Forms.Label();
            this.btnsavefile = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.Btnexit = new System.Windows.Forms.Button();
            this.txtvoucher = new System.Windows.Forms.TextBox();
            this.pickStarttime = new System.Windows.Forms.DateTimePicker();
            this.pickendtime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payroll";
            // 
            // btnsavefile
            // 
            this.btnsavefile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsavefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnsavefile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsavefile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnsavefile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnsavefile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnsavefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavefile.ForeColor = System.Drawing.Color.Silver;
            this.btnsavefile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavefile.Location = new System.Drawing.Point(332, 197);
            this.btnsavefile.Name = "btnsavefile";
            this.btnsavefile.Size = new System.Drawing.Size(100, 30);
            this.btnsavefile.TabIndex = 4;
            this.btnsavefile.Text = "Save File";
            this.btnsavefile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsavefile.UseVisualStyleBackColor = false;
            this.btnsavefile.Click += new System.EventHandler(this.btnsavefile_Click);
            // 
            // btnview
            // 
            this.btnview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnview.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Silver;
            this.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnview.Location = new System.Drawing.Point(438, 197);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(100, 30);
            this.btnview.TabIndex = 5;
            this.btnview.Text = "View";
            this.btnview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
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
            this.Btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // txtvoucher
            // 
            this.txtvoucher.Location = new System.Drawing.Point(141, 79);
            this.txtvoucher.Name = "txtvoucher";
            this.txtvoucher.Size = new System.Drawing.Size(144, 20);
            this.txtvoucher.TabIndex = 8;
            // 
            // pickStarttime
            // 
            this.pickStarttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickStarttime.Location = new System.Drawing.Point(338, 79);
            this.pickStarttime.Name = "pickStarttime";
            this.pickStarttime.Size = new System.Drawing.Size(200, 20);
            this.pickStarttime.TabIndex = 9;
            this.pickStarttime.Value = new System.DateTime(2022, 8, 29, 22, 56, 0, 0);
            // 
            // pickendtime
            // 
            this.pickendtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickendtime.Location = new System.Drawing.Point(579, 79);
            this.pickendtime.Name = "pickendtime";
            this.pickendtime.Size = new System.Drawing.Size(200, 20);
            this.pickendtime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Voucher use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(401, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(641, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(273, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "* Pay Notice that the calculetion is for each day and not per month";
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickendtime);
            this.Controls.Add(this.pickStarttime);
            this.Controls.Add(this.txtvoucher);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnsavefile);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.label1);
            this.Name = "FormPayroll";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnexit;
        private System.Windows.Forms.Button btnsavefile;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn houroutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteoutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtvoucher;
        private System.Windows.Forms.DateTimePicker pickStarttime;
        private System.Windows.Forms.DateTimePicker pickendtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}