using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAL:PersonDAL
    {
        private DateTime expirationDate;



        public UserDAL(string  id, string name, string password, DateTime expirationDate) : base(id, name, password)
        {
            this.expirationDate = expirationDate;
        }
        public UserDAL(string id, string name, string password) : base(id, name, password)
        {
            expirationDate = DateTime.Now.AddDays(365);
        }
    }
}
