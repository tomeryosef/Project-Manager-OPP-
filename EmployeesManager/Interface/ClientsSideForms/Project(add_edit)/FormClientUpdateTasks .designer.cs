namespace EmployeesManager
{
    partial class FormClientUpdateTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientUpdateTasks));
            this.MainTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtTaskTitle = new System.Windows.Forms.Label();
            this.BtnUpdateform = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txttaskid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttaskdetails = new System.Windows.Forms.Label();
            this.txtboxtaskdetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.comboboxurgency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.MainTitle.Controls.Add(this.label6);
            this.MainTitle.Controls.Add(this.BtnExit);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTitle.Location = new System.Drawing.Point(0, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(558, 38);
            this.MainTitle.TabIndex = 2;
            this.MainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Maintitle_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Project Form";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::EmployeesManager.Properties.Resources.Close;
            this.BtnExit.Location = new System.Drawing.Point(520, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(38, 38);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(140, 101);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(244, 23);
            this.txttitle.TabIndex = 3;
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.AutoSize = true;
            this.txtTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaskTitle.Location = new System.Drawing.Point(9, 101);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(82, 17);
            this.txtTaskTitle.TabIndex = 7;
            this.txtTaskTitle.Text = "Project title:";
            // 
            // BtnUpdateform
            // 
            this.BtnUpdateform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnUpdateform.FlatAppearance.BorderSize = 0;
            this.BtnUpdateform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateform.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateform.Location = new System.Drawing.Point(159, 414);
            this.BtnUpdateform.Name = "BtnUpdateform";
            this.BtnUpdateform.Size = new System.Drawing.Size(100, 35);
            this.BtnUpdateform.TabIndex = 11;
            this.BtnUpdateform.Text = "Update";
            this.BtnUpdateform.UseVisualStyleBackColor = false;
            this.BtnUpdateform.Click += new System.EventHandler(this.BtnUpdateFormCreate);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(287, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txttaskid
            // 
            this.txttaskid.AutoSize = true;
            this.txttaskid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaskid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttaskid.Location = new System.Drawing.Point(9, 74);
            this.txttaskid.Name = "txttaskid";
            this.txttaskid.Size = new System.Drawing.Size(73, 17);
            this.txttaskid.TabIndex = 14;
            this.txttaskid.Text = "Project ID:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(140, 74);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(244, 23);
            this.txtid.TabIndex = 13;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txttaskdetails
            // 
            this.txttaskdetails.AutoSize = true;
            this.txttaskdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaskdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttaskdetails.Location = new System.Drawing.Point(12, 230);
            this.txttaskdetails.Name = "txttaskdetails";
            this.txttaskdetails.Size = new System.Drawing.Size(90, 17);
            this.txttaskdetails.TabIndex = 38;
            this.txttaskdetails.Text = "Task Details:";
            // 
            // txtboxtaskdetails
            // 
            this.txtboxtaskdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxtaskdetails.Location = new System.Drawing.Point(140, 230);
            this.txtboxtaskdetails.Multiline = true;
            this.txtboxtaskdetails.Name = "txtboxtaskdetails";
            this.txtboxtaskdetails.Size = new System.Drawing.Size(244, 122);
            this.txtboxtaskdetails.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Project ManagerID:";
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeid.Location = new System.Drawing.Point(140, 130);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.ReadOnly = true;
            this.txtemployeeid.Size = new System.Drawing.Size(244, 23);
            this.txtemployeeid.TabIndex = 40;
            // 
            // comboboxurgency
            // 
            this.comboboxurgency.FormattingEnabled = true;
            this.comboboxurgency.Items.AddRange(new object[] {
            "Normal",
            "Urgent",
            "ASAP",
            "None"});
            this.comboboxurgency.Location = new System.Drawing.Point(140, 159);
            this.comboboxurgency.Name = "comboboxurgency";
            this.comboboxurgency.Size = new System.Drawing.Size(244, 21);
            this.comboboxurgency.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Urgency:";
            // 
            // FormClientUpdateTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 488);
            this.Controls.Add(this.comboboxurgency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemployeeid);
            this.Controls.Add(this.txtboxtaskdetails);
            this.Controls.Add(this.txttaskdetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttaskid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnUpdateform);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.MainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientUpdateTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMantCliente";
            this.MainTitle.ResumeLayout(false);
            this.MainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label txtTaskTitle;
        private System.Windows.Forms.Button BtnUpdateform;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label txttaskid;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txttaskdetails;
        public System.Windows.Forms.TextBox txtboxtaskdetails;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboboxurgency;
    }
}