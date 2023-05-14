﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormUpdateTasks : Form
    {
        public FormUpdateTasks()
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

        private void BtnUpdateFormCreate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var initialJson = File.ReadAllText(@"MainTasks.json");

                try
                {
                    var AllTasks = JsonConvert.DeserializeObject<List<Projects>>(initialJson);


                    var specificTask = AllTasks.FirstOrDefault(s => s.TasksId == int.Parse(this.txtid.Text));

                    specificTask.TasksTitle = this.txttitle.Text.ToString();
                    specificTask.Employee_em = int.Parse(this.txtemployeeid.Text);
                    specificTask.TasksDescription = this.txtboxtaskdetails.Text.ToString();
                    specificTask.DateEnd = Convert.ToDateTime(pickStartDate.Text);
                    specificTask.DateStart = Convert.ToDateTime(pickEndDate.Text);
                    specificTask.Urgency_em= comboboxurgency.Text.ToString();
                    specificTask.Status_em = comboboxstatus.Text.ToString();
                    specificTask.Client_id = int.Parse(this.txtclientid.Text);

                    string jsonToOutput = JsonConvert.SerializeObject(AllTasks, Formatting.Indented);
                    File.WriteAllText(@"MainTasks.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Tasks successfully Updated");
                this.Close();
            }
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
