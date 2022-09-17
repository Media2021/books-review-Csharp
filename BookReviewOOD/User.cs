using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews
{
    public class User : Person
    {
        private   DateTime expirationDate;

       

        public User(int id,string name, string  password,DateTime expirationDate) : base(id,name, password )
        {
            this.expirationDate = expirationDate;
        }
        public User(int id, string name, string password) : base(id,name, password)
        {
            expirationDate = DateTime.Now.AddDays(365);
        }

        public DateTime ExpirationDate { get { return expirationDate; } }   
        public override string Info()
        {
            return $"My id is {base.ID} ,my name is {base.Name} and my expiration date is {expirationDate} ";
        }

    }
}
