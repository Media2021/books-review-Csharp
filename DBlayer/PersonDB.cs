using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public  class PersonDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");

        public List<PersonEntity> GetAllPeople()
        {
            List<PersonEntity> personDALs = new List<PersonEntity>();
            personDALs.AddRange(ReadEmp());
            personDALs.AddRange(ReadUser());
            return personDALs;
        }
        public List<UsercEntity> ReadUser()
        {
            string sql = "SELECT * FROM Table_User ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<UsercEntity> users = new List<UsercEntity>();
            while (dr.Read())
            {
                users.Add(new UsercEntity(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToDateTime(dr[3])));

            }


            conn.Close();

            return users;
        }
        public List<EmpEntity> ReadEmp()
        {
            string sql = "SELECT * FROM Table_EMP ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<EmpEntity> employees = new List<EmpEntity>();
            while (dr.Read())
            {
                employees.Add(new EmpEntity(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToInt32(dr[3]), Convert.ToString(dr[4])));

            }


            conn.Close();

            return employees;
        }


        public void CreateEmp(EmpEntity Employee)
        {
            string sql = "insert into Table_EMP (name,password,bsn,role) values ( @name,@password,@bsn,@role);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            //cmd.Parameters.AddWithValue("@id",Employee.Id );
            cmd.Parameters.AddWithValue("@name", Employee.Name);
            cmd.Parameters.AddWithValue("@password", Employee.Password);
            cmd.Parameters.AddWithValue("@bsn", Employee.BSN1);
            cmd.Parameters.AddWithValue("@role", Employee.Role);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteEmp(EmpEntity Employee)
        {
            string sql = "DELETE FROM Table_EMP WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", Employee.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

      

        public void CreateUser(UsercEntity user)
        {
            string sql = "INSERT INTO Table_User (name,password,expirationDate) values ( @name,@password,@expirationDate);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            //cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@password", user.Password);
            //cmd.Parameters.AddWithValue("@type", "user");

            cmd.Parameters.AddWithValue("@expirationDate", user.ExpirationDate);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public void DeleteUser(UsercEntity user)
        {
            string sql = "DELETE FROM User WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", user.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
      

    }

}
