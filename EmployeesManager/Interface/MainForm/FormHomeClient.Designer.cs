namespace EmployeesManager
{
    partial class FormHomeClient
    {

        /// <summary>
        /// Designer variable required.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up the resources that are being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed of; false otherwise.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        // <summary>
        /// Method required to support the Designer. cannot be modified
        /// the content of the method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeClient));
            this.ParentContainerPanel = new System.Windows.Forms.Panel();
            this.panelContainerForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtclientname = new System.Windows.Forms.Label();
            this.fulldate = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnlogoff = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMainTitle = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.tmExpandMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFullHour = new System.Windows.Forms.Timer(this.components);
            this.ParentContainerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentContainerPanel
            // 
            this.ParentContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ParentContainerPanel.Controls.Add(this.panelContainerForm);
            this.ParentContainerPanel.Controls.Add(this.panel1);
            this.ParentContainerPanel.Controls.Add(this.panelMenu);
            this.ParentContainerPanel.Controls.Add(this.PanelMainTitle);
            this.ParentContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ParentContainerPanel.Name = "ParentContainerPanel";
            this.ParentContainerPanel.Size = new System.Drawing.Size(1100, 600);
            this.ParentContainerPanel.TabIndex = 0;
            // 
            // panelContainerForm
            // 
            this.panelContainerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerForm.Location = new System.Drawing.Point(230, 43);
            this.panelContainerForm.Name = "panelContainerForm";
            this.panelContainerForm.Size = new System.Drawing.Size(870, 457);
            this.panelContainerForm.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtclientname);
            this.panel1.Controls.Add(this.fulldate);
            this.panel1.Controls.Add(this.Hour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(230, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 100);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(31, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client";
            // 
            // txtclientname
            // 
            this.txtclientname.AutoSize = true;
            this.txtclientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclientname.ForeColor = System.Drawing.Color.LightGray;
            this.txtclientname.Location = new System.Drawing.Point(31, 21);
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.Size = new System.Drawing.Size(85, 16);
            this.txtclientname.TabIndex = 5;
            this.txtclientname.Text = "Tomer Yosef";
            // 
            // fulldate
            // 
            this.fulldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fulldate.AutoSize = true;
            this.fulldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fulldate.ForeColor = System.Drawing.Color.White;
            this.fulldate.Location = new System.Drawing.Point(608, 71);
            this.fulldate.Name = "fulldate";
            this.fulldate.Size = new System.Drawing.Size(218, 20);
            this.fulldate.TabIndex = 4;
            this.fulldate.Text = "Monday, September 26, 2022";
            // 
            // Hour
            // 
            this.Hour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hour.AutoSize = true;
            this.Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.ForeColor = System.Drawing.Color.LightGray;
            this.Hour.Location = new System.Drawing.Point(612, 11);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(205, 54);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "22:00:00";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.btnlogoff);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 43);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 557);
            this.panelMenu.TabIndex = 2;
            // 
            // btnlogoff
            // 
            this.btnlogoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnlogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoff.Image = global::EmployeesManager.Properties.Resources.shut_down;
            this.btnlogoff.Location = new System.Drawing.Point(9, 511);
            this.btnlogoff.Name = "btnlogoff";
            this.btnlogoff.Size = new System.Drawing.Size(43, 37);
            this.btnlogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnlogoff.TabIndex = 13;
            this.btnlogoff.TabStop = false;
            this.btnlogoff.Click += new System.EventHandler(this.btnlogoff_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::EmployeesManager.Properties.Resources.menu2;
            this.btnMenu.Location = new System.Drawing.Point(181, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Image = global::EmployeesManager.Properties.Resources.Planes;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "My Projects";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelMainTitle
            // 
            this.PanelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.PanelMainTitle.Controls.Add(this.pictureBox8);
            this.PanelMainTitle.Controls.Add(this.label1);
            this.PanelMainTitle.Controls.Add(this.btnNormal);
            this.PanelMainTitle.Controls.Add(this.btnMinimizar);
            this.PanelMainTitle.Controls.Add(this.btnMaximizar);
            this.PanelMainTitle.Controls.Add(this.btnexit);
            this.PanelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelMainTitle.Name = "PanelMainTitle";
            this.PanelMainTitle.Size = new System.Drawing.Size(1100, 43);
            this.PanelMainTitle.TabIndex = 1;
            this.PanelMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMainTitle_MouseDown);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(9, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proejct Manager ";
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = global::EmployeesManager.Properties.Resources.Normal;
            this.btnNormal.Location = new System.Drawing.Point(996, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(43, 43);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::EmployeesManager.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(950, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::EmployeesManager.Properties.Resources.maximize3;
            this.btnMaximizar.Location = new System.Drawing.Point(996, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(43, 43);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Image = global::EmployeesManager.Properties.Resources.Close;
            this.btnexit.Location = new System.Drawing.Point(1043, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 39);
            this.btnexit.TabIndex = 0;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // tmExpandMenu
            // 
            this.tmExpandMenu.Interval = 15;
            this.tmExpandMenu.Tick += new System.EventHandler(this.tmExpandMenu_Tick);
            // 
            // tmContMenu
            // 
            this.tmContMenu.Interval = 15;
            this.tmContMenu.Tick += new System.EventHandler(this.tmContMenu_Tick);
            // 
            // tmFullHour
            // 
            this.tmFullHour.Enabled = true;
            this.tmFullHour.Tick += new System.EventHandler(this.tmFullHour_Tick);
            // 
            // FormHomeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.ParentContainerPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "FormHomeClient";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ParentContainerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMainTitle.ResumeLayout(false);
            this.PanelMainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentContainerPanel;
        private System.Windows.Forms.Panel PanelMainTitle;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panelContainerForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fulldate;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnlogoff;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmExpandMenu;
        private System.Windows.Forms.Timer tmContMenu;
        private System.Windows.Forms.Timer tmFullHour;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label txtclientname;
    }
}

