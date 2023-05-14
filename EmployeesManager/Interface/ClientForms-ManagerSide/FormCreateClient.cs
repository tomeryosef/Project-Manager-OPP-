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
    public partial class FormCreateClient : Form
    {
        public FormCreateClient()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnCreateForm(object sender, EventArgs e)
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
                    itemToAdd.PhoneNumber_em = int.Parse(this.txtphone.Text);
                    itemToAdd.Gender_em = combogender.Text;
                    itemToAdd.Email = txtemail.Text.ToString();  


                    AllClients.Add(itemToAdd);
                    string jsonToOutput = JsonConvert.SerializeObject(AllClients, Formatting.Indented);
                    File.WriteAllText(@"ClientsInformation.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            MessageBox.Show("Client successfully Created");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
