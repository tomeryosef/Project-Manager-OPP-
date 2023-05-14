using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmployeesManager
{
    public class Employee : Person
    {
        protected string Address;
        protected string Position;
        protected string Qualifications;
        protected static int EmployeeID = 0;
        protected int EmployePersonalID;
        protected int EmployeeOfficeID;
        protected double Salary;
        protected DateTime JoinDate;
        protected string Password;

        public int Id_em { get { return EmployePersonalID; } set { EmployePersonalID = value; } }
        public string address_em { get { return Address; } set { Address = value; } }
        public string Qualifications_em { get { return Qualifications; } set { Qualifications = value; } }
        public double BaseSalary_em { get { return Salary; } set { Salary = value; } }
        public DateTime JoinDate_em { get { return JoinDate; } set { JoinDate = value; } }
        public string Position_em { get { return Position; } set { Position = value; } }
        public string Password_em { get { return Password; } set { Password = value; } }  
        public Employee()
        {

            Address = null;
            EmployeeID++;
            Id_em = EmployeeID;
            Qualifications = null;
            Salary = 0;
            JoinDate = DateTime.Now;
            Position = null;
            EmployeeOfficeID = 0;
            Password_em = null;
        }
        
    }

}



