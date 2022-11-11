using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public class MockPersonDB:IPersonDB
    {
        

        public List<PersonEntity> GetAllPeople()
        {
            List<PersonEntity> personDALs = new List<PersonEntity>();
            personDALs.AddRange(ReadEmp());
            personDALs.AddRange(ReadUser());
            return personDALs;
        }
        public List<UsercEntity> ReadUser()
        {
            List<UsercEntity> usercEntities = new List<UsercEntity>();
            UsercEntity usercEntity= new UsercEntity(11,"aysa","12",DateTime.Now);
            usercEntities.Add(usercEntity);
            return usercEntities;
        }
        public List<EmpEntity> ReadEmp()
        {
            List<EmpEntity> empDALs = new List<EmpEntity>();
            EmpEntity emp1 = new EmpEntity(1, "media", "123", 10, "admin");
            EmpEntity emp2 = new EmpEntity(2, "hannaa", "123", 10, "admin");
            empDALs.Add(emp1);
            empDALs.Add(emp2);
            return empDALs;
        }


        public void CreateEmp(EmpEntity Employee)
        {
        }

        public void DeleteEmp(EmpEntity Employee)
        {
        }



        public void CreateUser(UsercEntity user)
        {


        }
        public void DeleteUser(UsercEntity user)
        {
        }


    }
}
