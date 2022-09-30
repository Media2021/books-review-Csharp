using BookReviews.classes;
using DBlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Reflection.Metadata.BlobBuilder;
using DAO;
using LogicLayer.Mapper;

namespace BookReviews
{
    public  class PeopleManager
    {
      
       
        List<User> users = new List<User>();  
        List<Employee> employees = new List<Employee>();
        BooksDB myDB= new BooksDB();
        PersonDB personDB = new PersonDB();

       
        public PeopleManager()
        {
           users.Clear();
            
        }

        public List<User> Users()
        {
            return users;
        }
        public List<Employee> Employees()
        {
            return employees;
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }
        public void addUser(User user)
        {
            users.Add(user);
        }
        public List<Employee> GetEmployees()
        {
            return employees;   
        }
        public void addEmp(Employee employee)
        {
            employees.Add(employee);

            EmpDAL empDAO = MapToDAO.MapToEmpDAO(employee);
            
            personDB.CreateEmp(empDAO);

        }
        public void DeleteEmp(Employee employee)
        {
            employees.Remove(employee);
           
            EmpDAL empDAO = MapToDAO.MapToEmpDAO(employee);
            personDB.DeleteEmp(empDAO);
        }

    }
}
