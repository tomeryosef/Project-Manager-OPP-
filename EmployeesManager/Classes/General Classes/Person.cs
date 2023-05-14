using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace EmployeesManager {
    public abstract class Person
    {
        protected string FirstName;
        protected string LastName;
        protected string Gender;
        protected long PhoneNumber;
        protected DateTime BirthDate;


        public string FirstName_em { get { return FirstName; } set { FirstName = value; } }
        public string LastName_em { get { return LastName; } set { LastName = value; } }
        public string Gender_em { get { return Gender; } set { Gender = value; } }
        public DateTime BirthDate_em { get { return BirthDate; } set { BirthDate = value; } }
        public long PhoneNumber_em { get { return PhoneNumber; } set { PhoneNumber = value; } }

        public Person()
        {
            FirstName_em = null;
            LastName_em = null;
            Gender_em = null;
            PhoneNumber_em = 0;
   
        }

    }
}
