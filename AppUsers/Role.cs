using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsers
{
    public class Role
    {
        public int id { get; set; }
        private int roleid;
        private string name;
        private string pesa;

        public int RoleId
        {
            get { return roleid; }
            set { roleid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Pesa
        {
            get { return pesa; }
            set { pesa = value; }
        }

        public Role() { }

        public Role(string name, int RoleId, string pesa)
        {
            this.name = name;
            this.roleid = RoleId;
            this.pesa = pesa;
        }
    }
}
