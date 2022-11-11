using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsercEntity:PersonEntity
    {
        private DateTime expirationDate;

        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public UsercEntity(int  id, string name, string password, DateTime expirationDate) : base(id, name, password)
        {
            this.expirationDate = expirationDate;
        }
       
    }
}
