﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PersonEntity
    {
        private int id;
        private string name;
        private string password;

        public PersonEntity(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public int  Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
