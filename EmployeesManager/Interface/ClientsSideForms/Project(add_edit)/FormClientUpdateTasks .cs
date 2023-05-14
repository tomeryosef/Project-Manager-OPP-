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
    public partial class FormClientUpdateTasks : Form
    {
        public FormClientUpdateTasks()
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
            if (MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var initialJson = File.ReadAllText(@"MainTasks.json");

                try
                {
                    var AllTasks = JsonConvert.DeserializeObject<List<Projects>>(initialJson);


                    var specificTask = AllTasks.FirstOrDefault(s => s.TasksId == int.Parse(this.txtid.Text));
                    if (specificTask.fixes_limit())
                    {
                        specificTask.TasksTitle = this.txttitle.Text.ToString();
                        specificTask.TasksDescription = this.txtboxtaskdetails.Text.ToString();
                        specificTask.Urgency_em = this.comboboxurgency.Text.ToString();
                        specificTask.Fixes += 1;


                        string jsonToOutput = JsonConvert.SerializeObject(AllTasks, Formatting.Indented);
                        File.WriteAllText(@"MainTasks.json", jsonToOutput);
                        MessageBox.Show("Project successfully Updated, The manager responsible for the project got Notified");
                    }
                    else
                    {
                        MessageBox.Show("You Reached the limit of Fixes , You cannot edit the Projcet anymore.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
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

        
    }
}
