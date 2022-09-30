using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews.classes
{
    public class Employee : Person
    {
        private int BSN;
        private string role;



        public Employee(string id, string name, string password, int BSN, string role) : base(id, name, password)
        {
            this.BSN = BSN;
            this.role = role;
        }

        public int BSN1 { get { return BSN; } }
        public string Role { get { return role; } }

        public override string Info()
        {
            return $"My id is {ID}, my name is {Name}  and my role is {role} ";
        }


    }
}

