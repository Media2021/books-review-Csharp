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



        public void CreateEmp(EmpDAL Employee)
        {
            string sql = "insert into Table_People (id,name,password,bsn,role) values ( @id,@name,@password,@bsn,@role);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id",Employee.Id );
            cmd.Parameters.AddWithValue("@name", Employee.Name);
            cmd.Parameters.AddWithValue("@password", Employee.Password);
            cmd.Parameters.AddWithValue("@bsn", Employee.BSN1);
            cmd.Parameters.AddWithValue("@role", Employee.Role);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public void DeleteEmp(EmpDAL Employee)
        {
            string sql = "DELETE FROM Table_People WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", Employee.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<EmpDAL> ReadEmp()
        {
            string sql = "SELECT * FROM Table_People ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<EmpDAL> employees = new List<EmpDAL>();
            while (dr.Read())
            {
                employees.Add(new EmpDAL(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToInt32(dr[3]), Convert.ToString(dr[4])));

            }


            conn.Close();

            return employees;
        }
    }
}
