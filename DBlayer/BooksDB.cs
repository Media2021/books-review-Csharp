﻿
using System.Data.SqlClient;
using System.Data;
using DAO;

namespace DBlayer

{
    public class BooksDB
    {

        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");

    

        public void CreateBook(BookEntity book)
        {
            string sql = "insert into Book (id,title,author,type,description) values ( @Id,@title,@author,@type,@description);";

          SqlCommand cmd = new SqlCommand(sql,this.conn);
            cmd.Parameters.AddWithValue("@id",book.Id);
            cmd.Parameters.AddWithValue("@title",book.Title);
            cmd.Parameters.AddWithValue("@author",book.Author);
            cmd.Parameters.AddWithValue("@type",book.Type);
            cmd.Parameters.AddWithValue("@description",book.Description);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public void DeleteBook(BookEntity bookDAL)
        {
            string sql = "DELETE FROM Book WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", bookDAL.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<BookEntity> ReadBook()
        {
            string sql = "SELECT * FROM Book ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            
            conn.Open();
           SqlDataReader dr=  cmd.ExecuteReader();

            List<BookEntity> books = new List<BookEntity>();
            while (dr.Read())
            {
                books.Add(new BookEntity(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));

            }


            conn.Close();

            return books;
        }



        //cmd.Connection = con;
        //    con.Open();
        //    cmd.CommandText = "insert into BookAdd (ID,Title,BookAuthor,Pages,Quantity,Genre,Publication,Descriptions) values (" + ID + ",'" +
        //      title + "','" + bookAuthor + "'," + pages + ","
        //        + quantity + ",'" + genre + "' , " + publication + ",'"
        //        + descriptions + "');";
        //    cmd.ExecuteNonQuery();
        //    con.Close();


        public void CreateBookReview(ReviewEntity review)
        {
            string sql = "insert into Table_Review (userId,bookId,bookName,date,review) values (@userId,@bookId,@bookName,@date,@review);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
          
            cmd.Parameters.AddWithValue("@userId", review.User);
            cmd.Parameters.AddWithValue("@bookId", review.Id);
            cmd.Parameters.AddWithValue("@bookName", review.Title);
            cmd.Parameters.AddWithValue("@date", review.Date);
            cmd.Parameters.AddWithValue("@review", review.AddReview);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }


    }
}