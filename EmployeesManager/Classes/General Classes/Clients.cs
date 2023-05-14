using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager
{
    public class Clients : Person
    {
        protected static int id_client_stat = 0;
        protected int id_clients;
        protected string _email;
        protected string _password;

        public int IdClients { get { return id_clients; } set { id_clients = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public Clients()
        {
            id_client_stat++;
            IdClients = id_client_stat;
            Email = null;
            Password = null;
        }
        

        

      

    }

}



