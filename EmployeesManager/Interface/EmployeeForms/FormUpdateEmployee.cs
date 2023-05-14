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
    public partial class FormUpdateEmployee : Form
    {
        public FormUpdateEmployee()
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
        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormClient_Load(object sender, EventArgs e)
        {

        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnUpdateFormCreate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var initialJson = File.ReadAllText(@"Maininformation.json");

                try
                {
                    var AllEmployees = JsonConvert.DeserializeObject<List<Employee>>(initialJson);


                    var specificemployee = AllEmployees.FirstOrDefault(s => s.Id_em == int.Parse(this.txtid.Text));

                    specificemployee.FirstName_em = this.txtfirstname.Text.ToString();
                    specificemployee.LastName_em = this.txtlastname.Text.ToString();
                    specificemployee.Gender_em = this.combogender.Text.ToString();
                    specificemployee.address_em = this.txtaddress.Text.ToString();
                    specificemployee.Qualifications_em = this.comboqualifications.Text.ToString();
                    specificemployee.Position_em = this.comboposition.Text.ToString();
                    specificemployee.BaseSalary_em = double.Parse(this.txtbasesalary.Text);
                    specificemployee.BirthDate_em = Convert.ToDateTime(pickBirthDate.Text);
                    specificemployee.JoinDate_em = Convert.ToDateTime(pickJoinDate.Text);
                    specificemployee.PhoneNumber_em = int.Parse(this.txtphone.Text);


                    string jsonToOutput = JsonConvert.SerializeObject(AllEmployees, Formatting.Indented);
                    File.WriteAllText(@"Maininformation.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Employee successfully Uptated");
                this.Close();
            }
        }

       
    }
}
