using EmployeesManager.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormRegularEmployeeTasksList : Form
    {
        public FormRegularEmployeeTasksList()
        {
            InitializeComponent();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            GetSpecEmployeesview();
        }


        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUpdateTasks frm = new FormUpdateTasks();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txttitle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtemployeeid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.pickStartDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.pickEndDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.txtboxtaskdetails.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.comboboxurgency.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frm.comboboxstatus.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.txtclientid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


                frm.ShowDialog();

            }
            else
                MessageBox.Show("Invalid Selection, Please Try Again");
        }

      
        public void GetSpecEmployeesview()
        {
            string text = File.ReadAllText("MainTasks.json");
            var AllTasks = JsonConvert.DeserializeObject<List<Projects>>(text);
            List <Projects> allEmployeeTasks = new List<Projects>();
            IEnumerable<Projects> SpecificTasklist = AllTasks.Where(s => s.Employee_em == int.Parse(Settings.Default["Usernameid"].ToString()));
            foreach (var SpecificTask in SpecificTasklist)
            { allEmployeeTasks.Add(SpecificTask); }
            dataGridView1.DataSource = allEmployeeTasks;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var initialJson = File.ReadAllText(@"MainTasks.json");

                try
                {
                    var AllTasks = JsonConvert.DeserializeObject<List<Projects>>(initialJson);
                  
                    var specificTasks = AllTasks.FirstOrDefault(s => s.TasksId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    
                    AllTasks.Remove(specificTasks);


                    string jsonToOutput = JsonConvert.SerializeObject(AllTasks, Formatting.Indented);
                    File.WriteAllText(@"MainTasks.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Project successfully Deleted");
            }
        }

        private void BtnExit_Click_(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
