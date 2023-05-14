using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormUpdateClient : Form
    {
        public FormUpdateClient()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnUpdateFormCreate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update", "Uptade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var initialJson = File.ReadAllText(@"ClientsInformation.json");

                try
                {
                    var AllClients = JsonConvert.DeserializeObject<List<Clients>>(initialJson);


                    var specificclient = AllClients.FirstOrDefault(s => s.IdClients == int.Parse(this.txtid.Text)); // was s.EmployeePersonalID

                    specificclient.FirstName_em = this.txtfirstname.Text.ToString();
                    specificclient.LastName_em = this.txtlastname.Text.ToString();
                    specificclient.Gender_em = this.combogender.Text.ToString();
                    specificclient.BirthDate_em = Convert.ToDateTime(pickBirthDate.Text);
                    specificclient.PhoneNumber_em = int.Parse(this.txtphone.Text);
                    specificclient.Email = txtemailaddress.Text.ToString();
                 
                   
                    string jsonToOutput = JsonConvert.SerializeObject(AllClients, Formatting.Indented);
                    File.WriteAllText(@"ClientsInformation.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Client successfully Uptated");
                this.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
