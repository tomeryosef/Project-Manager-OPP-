using EmployeesManager.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class LoginForm : Form
    {
        //Constructor
        public LoginForm()
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


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                var initialJson = File.ReadAllText(@"Maininformation.json");
                var initialJsonClient = File.ReadAllText(@"ClientsInformation.json");
                int flag = 0;   ///0 = null , 1 = employee_id , 3 = client_id ,4 = allvalid, 5 = eror
                bool em_or_cl = true;
                try
                {
                    var AllEmployees = JsonConvert.DeserializeObject<List<Employee>>(initialJson);
                    var AllClients = JsonConvert.DeserializeObject<List<Clients>>(initialJsonClient);
                    var specificemployee = AllEmployees.FirstOrDefault(s => s.Id_em == int.Parse(txtusername.Text));

                    if (specificemployee != null)
                    {

                        if (specificemployee.Password_em == txtpassword.Text)
                        {
                            flag = 4;
                            if (specificemployee.Position_em.ToString() == "Manager")
                            {
                                Settings.Default["Usernameid"] = this.txtusername.Text;
                                FormHome Obj = new FormHome();
                                Obj.labelname.Text = specificemployee.FirstName_em.ToString() + " " + specificemployee.LastName_em.ToString();
                                Obj.labelposition.Text = specificemployee.Position_em.ToString();
                                Obj.Show();
                                this.Hide();
                            }
                            else
                            {
                                Settings.Default["Usernameid"] = this.txtusername.Text;
                                FormHomeEmployee Obj = new FormHomeEmployee();
                                Obj.labelname.Text = specificemployee.FirstName_em.ToString() + " " + specificemployee.LastName_em.ToString();
                                Obj.labelposition.Text = specificemployee.Position_em.ToString();
                                Obj.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            flag = 1;
                            em_or_cl = false;
                        }
                    }

                    if (flag == 0 || em_or_cl == false)
                    {
                        var specificcleint = AllClients.FirstOrDefault(s => s.IdClients == int.Parse(this.txtusername.Text));
                        if (specificcleint != null)
                        {
                            flag = 3;
                            if (specificcleint.Password == txtpassword.Text)
                            {
                                flag = 4;
                                Settings.Default["Usernameid"] = this.txtusername.Text;
                                FormHomeClient Obj = new FormHomeClient();
                                Obj.txtclientname.Text = specificcleint.FirstName_em.ToString() + " " + specificcleint.LastName_em.ToString();
                                Obj.Show();
                                this.Hide();

                            }

                        }

                    }
                }

                catch
                {
                    flag = 5;
                    MessageBox.Show("Wrong User/Password Information");
                    txtusername.Clear();
                    txtpassword.Clear();
                }
                if (flag == 1 || flag == 3)
                {
                    MessageBox.Show("Wrong Password Information");
                    txtusername.Clear();
                    txtpassword.Clear();
                }
                if (flag == 0)
                {
                    MessageBox.Show("Wrong User Information");
                    txtusername.Clear();
                    txtpassword.Clear();
                }
            }
        }

            private void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }


        private void firsttimelogin_Click(object sender, EventArgs e)
        {
            FormFirstTimeLogin frm = new FormFirstTimeLogin();
            
            frm.Show();
            this.Hide();

        }

        

        private void lblcreateaccount_Click(object sender, EventArgs e)
        {
            FormClientRegister frm = new FormClientRegister();
            frm.Show();
            this.Hide();
        }

        // Hours Method ----------------------------------------------------------
        private void tmFullhour_Tick(object sender, EventArgs e)
        {
            fulldate.Text = DateTime.Now.ToLongDateString();
            Hour.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

    }
}

