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
    public partial class FormClientList : Form
    {
        public FormClientList()
        {
            InitializeComponent();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUpdateClient frm = new FormUpdateClient();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtlastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtphone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.combogender.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.pickBirthDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txtemailaddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("Invalid Selection, Please Try Again");
        }

        
        public void GetClientsview()
        {
            string text = File.ReadAllText("ClientsInformation.json");
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
                var initialJson = File.ReadAllText(@"ClientsInformation.json");

                try
                {
                    var AllClients = JsonConvert.DeserializeObject<List<Clients>>(initialJson);


                    var specificClient = AllClients.FirstOrDefault(s => s.IdClients == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())); // was s.EmployePersonalID

                    AllClients.Remove(specificClient);


                    string jsonToOutput = JsonConvert.SerializeObject(AllClients, Formatting.Indented);
                    File.WriteAllText(@"ClientsInformation.json", jsonToOutput);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Client successfully Deleted");
            }
        }

        private void clientsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCreateClient frm = new FormCreateClient();
            frm.ShowDialog();
        }

        private void Btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            GetClientsview();

        }

        private void Exportlist_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var initialJson = File.ReadAllText(@"ClientsInformation.json");

            try
            {
                var Allclients = JsonConvert.DeserializeObject<List<Clients>>(initialJson);

                Bitmap bmp = Properties.Resources.logo;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 10, 10, 80, 80);
                e.Graphics.DrawString("current status Clients", new Font("Ariel", 30, FontStyle.Bold), Brushes.Black, new Point(230, 30));
                e.Graphics.DrawString("______________________________________________________________________________________", new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 80));
                int counter = 140;
                int counter_plus() { return counter += 40; };
                int count = 0;

                foreach (var item in Allclients)
                {
                    e.Graphics.DrawString(++count + ") ", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(10, counter));
                    e.Graphics.DrawString("id: ", new Font("Ariel", 15, FontStyle.Bold), Brushes.Black, new Point(50, counter));
                    e.Graphics.DrawString(" " + item.IdClients, new Font("Ariel", 15, FontStyle.Regular), Brushes.Black, new Point(70, counter));
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
