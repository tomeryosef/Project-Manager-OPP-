using EmployeesManager.Properties;
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
    public partial class FormClientCreateTasks : Form
    {
        public FormClientCreateTasks()
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

        private void BtnUpdateFormCreate(object sender, EventArgs e)
        {
            var initialJson = File.ReadAllText(@"MainTasks.json");
            if (MessageBox.Show("Are you sure you want to Create", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                try
                {
                    var AllTasks = JsonConvert.DeserializeObject<List<Projects>>(initialJson);

                    var itemToAdd = new Projects();

                    itemToAdd.TasksTitle = txttitle.Text;
                    itemToAdd.TasksDescription = txtboxtaskdetails.Text;
                    itemToAdd.Urgency_em = comboboxurgency.Text;
                    itemToAdd.Client_id = int.Parse((string)Settings.Default["Usernameid"]);
                                     
                    string s = JToken.FromObject(itemToAdd).ToString(Formatting.Indented);
                    AllTasks.Add(itemToAdd);
                    string jsonToOutput = JsonConvert.SerializeObject(AllTasks, Formatting.Indented);
                    File.WriteAllText(@"MainTasks.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            MessageBox.Show("Projcet successfully Created and Transfer to the Managers.");
            this.Close();
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

