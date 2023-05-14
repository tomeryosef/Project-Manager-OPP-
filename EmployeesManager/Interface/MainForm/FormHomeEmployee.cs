using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormHomeEmployee : Form
    {
        //Constructor
        public FormHomeEmployee()
        {
            InitializeComponent();
            ///These lines eliminate the flickering of the form or controls in the graphical interface
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //METHOD TO RESIZE/RESIZE FORM RUNTIME ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelMaintitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //METHODS TO CLOSE, MAXIMIZE, MINIMIZE FORM------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METHODS FOR SLIDING MENU ANIMATION--------------------------------
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------WITH SLIDING EFFECT
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandMenu.Start();
            }

            
        }


        //METHOD TO OPEN FORM WITHIN PANEL-----------------------------------------------------
        private void OpenFormInPanel(object formtochange)
        {
            if (this.panelConForm.Controls.Count > 0)
                this.panelConForm.Controls.RemoveAt(0);
            Form fh = formtochange as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelConForm.Controls.Add(fh);
            this.panelConForm.Tag = fh;
            fh.Show();
        }
        //METHOD TO SHOW LOGO FORM AT STARTUP ---------------------------------------- ------------------
        private void ShowFormLogo()
        {
            OpenFormInPanel(new FormLogo());
        }

        private void FormHome_Load(object sender, EventArgs e) // Was FormMenuPrincipal_Load
        {
            ShowFormLogo();
        }
        //METHOD TO SHOW LOGO FORM when CLOSING OTHER FORM -------------------------------------- --------------------
        private void ShowFormLogoOnCloseForms(object sender, FormClosedEventArgs e)
        {
            ShowFormLogo();
        }
        //METHODS TO OPEN OTHER FORMS AND SHOW FORM LOGO WHEN CLOSING ------------------------------------ ----------------------

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegularEmployeeTasksList frm = new FormRegularEmployeeTasksList();
            frm.FormClosed += new FormClosedEventHandler(ShowFormLogoOnCloseForms);
            OpenFormInPanel(frm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogoff_click(object sender, EventArgs e)
        {
            LoginForm fm = new LoginForm();
            fm.Show();
            this.Hide();
        }

        private void tmContMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        private void tmExpandMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            FormPayroll frm = new FormPayroll();
            frm.FormClosed += new FormClosedEventHandler(ShowFormLogoOnCloseForms);
            OpenFormInPanel(frm);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }


        // Hours Method ----------------------------------------------------------
        private void tmfullhour_Tick(object sender, EventArgs e)
        {
            fulldate.Text = DateTime.Now.ToLongDateString();
            Hour.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

    }
}
