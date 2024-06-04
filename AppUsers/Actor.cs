using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsers
{
    public class Actor
    {

        public int id { get; set; }
        private int fio;
        private string sex;
        private string zvanie;

        public int FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Zvanie
        {
            get { return zvanie; }
            set { zvanie = value; }
        }

        public Actor() { }

        public Actor(int fio, string sex, string zvanie)
        {
            this.fio = fio;
            this.sex = sex;
            this.zvanie = zvanie;
        }
    }
}
