using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public interface IPersonDB
    {
        public List<PersonEntity> GetAllPeople();
        public List<UsercEntity> ReadUser();
        public List<EmpEntity> ReadEmp();


        public void CreateEmp(EmpEntity Employee);

        public void DeleteEmp(EmpEntity Employee);



        public void CreateUser(UsercEntity user);
        public void DeleteUser(UsercEntity user);
    }
}
