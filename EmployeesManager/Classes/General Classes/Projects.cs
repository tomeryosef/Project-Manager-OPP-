using System;

namespace EmployeesManager
{
    public class Projects : Employee
    {
        protected static int Tasks_id = 0;
        protected int Tasks_count;
        protected string Tasks_description;
        protected string Tasks_title;
        protected DateTime Start;
        protected DateTime End;
        protected int Employee_idfortask;
        protected string Status;
        protected string Urgency;
        protected int Clientid;
        protected int reservations;


        public int Employee_em {  get { return Employee_idfortask; } set { Employee_idfortask = value;} }
        public string TasksDescription { get { return Tasks_description; } set { Tasks_description = value; } }
        public int  TasksId { get { return Tasks_count; } set { Tasks_count = value; } }
        public string TasksTitle { get { return Tasks_title; } set { Tasks_title = value; } }
        public DateTime DateStart { get { return Start; } set { Start = value; } }
        public DateTime DateEnd { get { return End; } set { End = value; } }
        public string Status_em { get { return Status; } set { Status = value; } } 
        public string Urgency_em { get { return Urgency; } set { Urgency = value; } }
        public int Client_id { get { return Clientid; } set { Clientid = value;} }
        public int Fixes { get { return reservations; } set { reservations = value; } }

        public Projects()
        {
            TasksDescription = null;
            Tasks_id++;
            TasksId = Tasks_id;
            TasksTitle = null;
            DateStart = DateTime.Now;
            DateEnd = DateTime.Now;
            Status = "Started";
            Urgency = "Normal";
            Clientid = 0;
            Fixes = 0;
        }

        public bool fixes_limit()
        {
            if (Fixes < 5)
                return true;
            return false;
        }
    }

   
}