using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }


        private void FormEmployee_Load(object sender, EventArgs e)
        {
            GetEmployeesview();

        }
        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUpdateEmployee frm = new FormUpdateEmployee();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtlastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtaddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txtphone.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frm.txtbasesalary.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.comboposition.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frm.combogender.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.comboqualifications.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.pickBirthDate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.pickJoinDate.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("Invalid Selection, Please Try Again");
        }


        private void btncreate_Click(object sender, EventArgs e)
        {
            FormCreateEmployee frm = new FormCreateEmployee();
            frm.ShowDialog();
        }
        public void GetEmployeesview()
        {
            string text = File.ReadAllText("Maininformation.json");
            var jsonDict = JsonConvert.DeserializeObject<DataTable>(text);
            dataGridView1.DataSource = jsonDict;

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
                var initialJson = File.ReadAllText(@"Maininformation.json");

                try
                {
                    var AllEmployees = JsonConvert.DeserializeObject<List<Employee>>(initialJson);


                    var specificemployee = AllEmployees.FirstOrDefault(s => s.Id_em == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())); // was s.EmployePersonalID

                    AllEmployees.Remove(specificemployee);


                    string jsonToOutput = JsonConvert.SerializeObject(AllEmployees, Formatting.Indented);
                    File.WriteAllText(@"Maininformation.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Employee successfully Deleted");
            }
        }

        private void Exportlist_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
  

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var initialJson = File.ReadAllText(@"Maininformation.json");

            try
            {
                var AllEmployees = JsonConvert.DeserializeObject<List<Employee>>(initialJson);

                Bitmap bmp = Properties.Resources.logo;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 10, 10, 80, 80);
                e.Graphics.DrawString("current status employee", new Font("Ariel", 30, FontStyle.Bold), Brushes.Black, new Point(230, 30));
                e.Graphics.DrawString("______________________________________________________________________________________", new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 80));
                int counter = 140;
                int counter_plus() { return counter += 40; };
                int count = 0;

                foreach (var item in AllEmployees)
                {
                    e.Graphics.DrawString(++count + ") ", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(10, counter));
                    e.Graphics.DrawString("id: ", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(50, counter));
                    e.Graphics.DrawString(" " + item.Id_em, new Font("Ariel", 15, FontStyle.Regular), Brushes.Black, new Point(70, counter));
                    e.Graphics.DrawString(" first name: ", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(110, counter));
                    e.Graphics.DrawString(item.FirstName_em, new Font("Ariel", 15, FontStyle.Regular), Brushes.Black, new Point(270, counter));
                    e.Graphics.DrawString("  last name: ", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(400, counter));
                    e.Graphics.DrawString(item.LastName_em, new Font("Ariel", 15, FontStyle.Regular), Brushes.Black, new Point(600, counter));
                    counter_plus();
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Couldnt found the Employee Mention");
            }
        }
    }
}
