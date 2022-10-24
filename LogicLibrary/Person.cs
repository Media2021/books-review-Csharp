using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews.classes
{
    public abstract class Person
    {

        private int  id;
        private string name;
        private string password;

       

        public Person(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;

        }
        public Person( string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public int  ID { get { return id; } }
      

        public string Name { get { return name; } }
       

        public string Password { get { return password; } }

        public bool Login(string password)
        {
            if (this.password == password)
            {
                return true;
            }
            return false;
        }

        public virtual string Info()
        {
            return $"My id is {id} ,My name is  {name} ";
        }




    }
}
