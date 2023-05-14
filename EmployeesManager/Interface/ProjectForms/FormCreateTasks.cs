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
    public partial class FormCreateTasks : Form
    {
        public FormCreateTasks()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        private void Maintitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
 
        private void txtid_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnUpdateFormCreate(object sender, EventArgs e)
        {
            var initialJson = File.ReadAllText(@"MainTasks.json");
            if (MessageBox.Show("Are you sure you want to Create", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                try
                {
                    var AllTasks = JsonConvert.DeserializeObject<List<Projects>>(initialJson);


                    var itemToAdd = new Projects();

                    itemToAdd.TasksTitle = txttitle.Text;
                    itemToAdd.Employee_em = int.Parse(this.txtemployeeid.Text);
                    itemToAdd.TasksDescription = this.txtboxtaskdetails.Text;
                    itemToAdd.DateStart = Convert.ToDateTime(pickStartDate.Text);
                    itemToAdd.DateEnd = Convert.ToDateTime(pickEndDate.Text);
                    itemToAdd.Urgency_em = comboboxurgency.Text;
                    itemToAdd.Status_em = comboboxstatus.Text;
                    itemToAdd.Client_id = int.Parse(this.txtclientid.Text);

                    AllTasks.Add(itemToAdd);
                    string jsonToOutput = JsonConvert.SerializeObject(AllTasks, Formatting.Indented);
                    File.WriteAllText(@"MainTasks.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            MessageBox.Show("Project successfully Created");
            this.Close();
        
        }

            private void pickStartDate_ValueChanged(object sender, EventArgs e)
            {

            }

            private void label13_Click(object sender, EventArgs e)
            {

            }

            private void label12_Click(object sender, EventArgs e)
            {

            }

            private void pickEndDate_ValueChanged(object sender, EventArgs e)
            {

            }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
    }

