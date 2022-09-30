using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PersonDAL
    {
        private string id;
        private string name;
        private string password;

        public PersonDAL(string id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public string  Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
