using EmployeesManager.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormClientRegister : Form
    {
        //Constructor
        public FormClientRegister()
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

        
     
        //METHOD TO DRAG THE FORM---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelMainTitle_MouseDown(object sender, MouseEventArgs e)
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


        //METHOD TO OPEN FORM WITHIN PANEL-----------------------------------------------------
        private void OpenFormInPanel(object formtochange)
        {
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
 
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            var initialJson = File.ReadAllText(@"ClientsInformation.json");
            if (MessageBox.Show("Are you sure you want to Create", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                try
                {
                    var AllClients = JsonConvert.DeserializeObject<List<Clients>>(initialJson);


                    var itemToAdd = new Clients();

                    itemToAdd.FirstName_em = txtfirstname.Text;
                    itemToAdd.LastName_em = txtlastname.Text;
                    itemToAdd.BirthDate_em = Convert.ToDateTime(pickBirthDate.Text);
                    itemToAdd.PhoneNumber_em = long.Parse(this.txtphone.Text);
                    itemToAdd.Gender_em = combogender.Text;
                    itemToAdd.Email = txtemail.Text;
                    itemToAdd.Password = txtPassword.Text;


                    AllClients.Add(itemToAdd);
                    string jsonToOutput = JsonConvert.SerializeObject(AllClients, Formatting.Indented);
                    File.WriteAllText(@"ClientsInformation.json", jsonToOutput);
                    MessageBox.Show("Client successfully Created Your Id is :" + itemToAdd.IdClients.ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
    

            private void btnreset_Click(object sender, EventArgs e)
          {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtphone.Clear();
            txtPassword.Clear();
         }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        // Hours Method ----------------------------------------------------------
       
        private void tmHourfulldisplay_Tick(object sender, EventArgs e)
        {
            fulldate.Text = DateTime.Now.ToLongDateString();
            Hour.Text = DateTime.Now.ToString("HH:mm:ssss");
        }



    }
}

