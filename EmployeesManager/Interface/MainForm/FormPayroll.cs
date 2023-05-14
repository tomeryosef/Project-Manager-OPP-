using EmployeesManager.Properties;
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
    public partial class FormPayroll : Form
    {
        public FormPayroll()
        {
            InitializeComponent();
        }


        private void btnview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var initialJson = File.ReadAllText(@"Maininformation.json");

            try
            {
                var AllEmployees = JsonConvert.DeserializeObject<List<Employee>>(initialJson);
                var specificemployee = AllEmployees.FirstOrDefault(s => s.Id_em == int.Parse((string)Settings.Default["Usernameid"]));
                var specificeemployeepayroll = new Payrolls(specificemployee);
                specificeemployeepayroll.HourIn = int.Parse(pickStarttime.Value.Hour.ToString());  
                specificeemployeepayroll.HourOut = int.Parse(pickendtime.Value.Hour.ToString());  
                specificeemployeepayroll.MinuteIn = int.Parse(pickStarttime.Value.Minute.ToString());  
                specificeemployeepayroll.MinuteOut = int.Parse(pickendtime.Value.Minute.ToString());
                var vac =txtvoucher.Text;
                if (vac == "")
                    specificeemployeepayroll.Vucher = 0;
                else
                {
                    specificeemployeepayroll.Vucher = double.Parse(txtvoucher.Text);
                }
                int counter = 100;
                int counter_plus() { return counter += 40; };
                Bitmap bmp = Properties.Resources.logo;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 10, 10, 80, 80);
                e.Graphics.DrawString("Payroll Daily report ", new Font("Ariel", 30, FontStyle.Bold), Brushes.Black, new Point(250, 30));
                e.Graphics.DrawString("______________________________________________________________________________________", new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 80));
                e.Graphics.DrawString("Id  :" + specificemployee.Id_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("First Name : " + specificemployee.FirstName_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Last Name : " + specificemployee.LastName_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Gender : " + specificemployee.Gender_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Position  : " + specificemployee.Position_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Address : " + specificemployee.address_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Qualifications : " + specificemployee.Qualifications_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Birthdate : " + specificemployee.BirthDate_em.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("JoinDate : " + specificemployee.JoinDate_em.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("PhoneNumber: " + specificemployee.PhoneNumber_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("BaseSalary: " + specificemployee.BaseSalary_em + "$", new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                specificeemployeepayroll.use_voucher(specificeemployeepayroll.Vucher);
                specificeemployeepayroll.salary_calculat();
                specificeemployeepayroll.taxes_calculat();
                specificeemployeepayroll.pension_calculat();
                e.Graphics.DrawString("Daily Voucher uses: " + specificeemployeepayroll.Vucher + "$", new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Daily Voucher left: " + specificeemployeepayroll.VoucherLimit + "$", new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("taxes for this day : " + specificeemployeepayroll.tax_em, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("pension for this day : " + specificeemployeepayroll.Pension, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));
                e.Graphics.DrawString("Salary for this day : " + specificeemployeepayroll.DaySalary, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(10, counter_plus()));


            }

            catch (Exception)
            {

                MessageBox.Show("Couldnt found the Employee Mention");
            }
        }

        private void btnsavefile_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;
            printDocument1.Print();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
