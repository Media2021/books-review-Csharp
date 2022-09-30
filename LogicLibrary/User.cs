using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews.classes
{
    public class User : Person
    {
        private DateTime expirationDate;



        public User(string  id, string name, string password, DateTime expirationDate) : base(id, name, password)
        {
            this.expirationDate = expirationDate;
        }
        public User(string  id, string name, string password) : base(id, name, password)
        {
            expirationDate = DateTime.Now.AddDays(365);
        }

        public DateTime ExpirationDate { get { return expirationDate; } }
        public override string Info()
        {
            return $"My id is {ID} ,my name is {Name} and my expiration date is {expirationDate} ";
        }

    }
}
