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
    public partial class FormCreateEmployee : Form
    {
        public FormCreateEmployee()
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
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnCreateForm(object sender, EventArgs e)
        {
            var initialJson = File.ReadAllText(@"Maininformation.json");
            if (MessageBox.Show("Are you sure you want to Create", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                try
                {
                    var AllEmployees = JsonConvert.DeserializeObject<List<Employee>>(initialJson);


                    var itemToAdd = new Employee();

                    itemToAdd.FirstName_em = txtfirstname.Text;
                    itemToAdd.LastName_em = txtlastname.Text;
                    itemToAdd.address_em = txtaddress.Text;
                    itemToAdd.BaseSalary_em = double.Parse(this.txtbasesalary.Text);
                    itemToAdd.BirthDate_em = Convert.ToDateTime(pickBirthDate.Text);
                    itemToAdd.JoinDate_em = Convert.ToDateTime(pickJoinDate.Text);
                    itemToAdd.Position_em = comboposition.Text;
                    itemToAdd.PhoneNumber_em = int.Parse(this.txtphone.Text);
                    itemToAdd.Gender_em = combogender.Text;
                    itemToAdd.Qualifications_em = comboqualifications.Text;

                    AllEmployees.Add(itemToAdd);
                    string jsonToOutput = JsonConvert.SerializeObject(AllEmployees, Formatting.Indented);
                    File.WriteAllText(@"Maininformation.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 MessageBox.Show("Employee successfully Created");
                 this.Close();
        }

        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
