using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppUsers
{
    public class Performance
    {
        public int id { get; set; }
        private int roleid;
        private int tableid;
        private int numbergroup;
        private string startdate;
        private string finishdate;

        public int NumberGroup
        {
            get { return numbergroup; }
            set { numbergroup = value; }
        }

        public string StartDate
        {
            get { return startdate; }
            set { startdate = value; }
        }

        public string FinishDate
        {
            get { return finishdate; }
            set { finishdate = value; }
        }

        public int RoleId
        {
            get { return roleid; }
            set { roleid = value; }
        }

        public int TableId
        {
            get { return tableid; }
            set { tableid = value; }
        }

 
        public Performance() { }

        public Performance(string finish, string start, int roleid, int tableid, int number)
        {
            this.finishdate = finish;
            this.startdate = start;
            this.roleid = roleid;
            this.tableid = tableid;
            this.numbergroup = number;
        }
    }
}
