using System.Collections.Generic;

namespace EmployeesManager
{
    public class Payrolls : Employee
    {
        protected int hour_in;
        protected int minute_in;
        protected int hour_out;
        protected int minute_out;
        protected double tax;
        protected double pension;
        protected double voucher;
        protected double voucher_limit;
        protected double day_salary;


        public int HourIn { get { return hour_in; } set { hour_in = value; } }
        public int MinuteIn { get { return minute_in; } set { minute_in = value; } }
        public int HourOut { get { return hour_out; } set { hour_out = value; } }
        public int MinuteOut { get { return minute_out; } set { minute_out = value; } }
        public double tax_em { get { return tax; } set { tax = value; } }
        public double Pension { get { return pension; } set { pension = value; } }
        public double Vucher { get { return voucher; } set { voucher = value; } }
        public double VoucherLimit { get { return voucher_limit; } set { voucher_limit = value; } }
        public double DaySalary { get { return day_salary; } set { day_salary = value; } }
        public Payrolls()
        {
            HourIn = 0;
            MinuteIn = 0;
            HourOut = 0;
            MinuteOut = 0;
            MinuteOut = 0;
            Pension = 0;
            VoucherLimit = 1000;
            Vucher = 0;
            tax_em = 0;
            DaySalary = 0;
        }
        public Payrolls(Employee e)
        {
            HourIn = 0;
            MinuteIn = 0;
            HourOut = 0;
            MinuteOut = 0;
            MinuteOut = 0;
            Pension = 0;
            VoucherLimit = 1000;
            Vucher = 0;
            tax_em = 0;
            DaySalary = 0;
            Salary = e.BaseSalary_em;
        }
        public void salary_calculat()
        {
            double tmp = 0;
            if (HourIn < HourOut)
                tmp += HourOut - HourIn;
            else if (HourIn > HourOut)
                tmp += (24 - HourIn) + HourOut;
            if (MinuteIn < MinuteOut)
                tmp += (MinuteOut - MinuteIn) * 0.1;
            else if (MinuteIn > MinuteOut)
                tmp += ((60 - MinuteIn) + MinuteOut) * 0.1;
            if (tmp != 0)
                this.DaySalary = tmp * Salary;
            else
                this.DaySalary = Salary;

        }
        public void taxes_calculat()
        {
            tax_em = DaySalary * 0.05;
        }

        public void pension_calculat()
        {
            Pension = DaySalary * 0.1;
        }


        public void use_voucher(double num)
        {
            VoucherLimit -= Vucher;
        }
    }



}