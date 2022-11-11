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
using System.Data;

namespace BookReviews
{
    public  class PeopleManager
    {
  
        BooksDB myDB= new BooksDB();
        IPersonDB personDB;
        List<Person> people = new List<Person>();
        List<User> users = new List<User>();
       
        public PeopleManager(IPersonDB personDB)
        {
            this.personDB = personDB;
            UpdatePeopleList();            
        }
        public List<Person> GetPeople()
        {
            return people;
        }
        public List<User> GetUser()
        {
            return users;
        }

        public void UpdatePeopleList()
        {
            people.Clear();
            List<PersonEntity> personEntity = new List<PersonEntity>();

            personEntity.AddRange(personDB.GetAllPeople());

            foreach (PersonEntity person in personEntity)
            {
                if (person is EmpEntity)
                {
                    people.Add(MapToDAL.MapToEmp((EmpEntity)person));
                   
                }
                else
                {
                    people.Add(MapToDAL.MapToUser((UsercEntity)person));
                    
                }
            }
            

        }
        public bool Login(string username,string password)
        {
            bool isTrue = people.Exists(x => x.Name == username);

            if (isTrue)
            {
                Person loggedUser = people.Find(x => x.Name == username);

                
                 return loggedUser.Login(password);

                
            }
            return false;

        }
        public Person GetLoggedInUser(string username)
        {
            Person loggedUser = people.Find(x => x.Name == username);
            return loggedUser;
        }

      



        public void AddUser(User user)
        {
            people.Add(user);

            UsercEntity userDAL = MapToDAL.MapToUserDAL(user);

            personDB.CreateUser(userDAL);
        } 


        public void DeleteUser(User user)
        {
            people.Remove(user);
            UsercEntity userEntity = MapToDAL.MapToUserDAL(user);
            personDB.DeleteUser(userEntity);
        }


        public void addEmp(Employee employee)
        {
            people.Add(employee);

            EmpEntity empEntity = MapToDAL.MapToEmpDAL(employee);
            
            personDB.CreateEmp(empEntity);

        }
        public void DeleteEmp(Employee employee)
        {
            people.Remove(employee);

            EmpEntity empEntity = MapToDAL.MapToEmpDAL(employee);
            personDB.DeleteEmp( empEntity );
        }
      



    }
}
