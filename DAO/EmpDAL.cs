using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class EmpDAL:PersonDAL
    {
        private int BSN;
        private string role;

        public EmpDAL(string id, string name, string password,int BSN,string role) : base(id, name, password)
        {
            this.role = role;
            this.BSN = BSN; 
        }

        public int BSN1 { get => BSN; set => BSN = value; }
        public string Role { get => role; set => role = value; }
    }
}
