
using System.Data.SqlClient;
using System.Data;
using DAO;

namespace DBlayer

{
    public class BooksDB
    {

        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= mydatabase;User Id = myId; Password=myPassword; ");

    

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



    


        public void CreateBookReview(ReviewEntity review)
        {
            string sql = "insert into Table_Review (bookId,bookName,userName,review,date) values (@bookId,@bookName,@userName,@review,@date);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

           
            cmd.Parameters.AddWithValue("@bookId", review.Id);
            cmd.Parameters.AddWithValue("@bookName", review.Title);
            cmd.Parameters.AddWithValue("@userName", review.User.Name);
            cmd.Parameters.AddWithValue("@review", review.AddReview);
            cmd.Parameters.AddWithValue("@date", review.Date);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public List<ReviewEntity> ReadReviews()
        {
            string sql ="SELECT * FROM Table_Review as re inner join Table_User  as us on re.userName = us.name";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<ReviewEntity> reviews = new List<ReviewEntity>();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr[0]);
                string bookId = Convert.ToString(dr[1]);
                string title = Convert.ToString(dr[2]);
                string userName= Convert.ToString(dr[3]);
                string review = Convert.ToString(dr[4]);
                DateTime date = Convert.ToDateTime(dr[5]);
                int userId = Convert.ToInt32(dr[6]);
                string password = Convert.ToString(dr[8]);
                DateTime expDate=Convert.ToDateTime(dr[9]);

                UsercEntity user = new UsercEntity(userId,userName,password,expDate);

                reviews.Add(new ReviewEntity(id, bookId, title, user, review, date));

            }

            conn.Close();

            return reviews;
        }
        public void DeleteReview(ReviewEntity reviewDAL)
        {
            string sql = "DELETE FROM Table_Review WHERE reviewId = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", reviewDAL.ReviewId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateReview(ReviewEntity reviewDAL)
        {
            string sql = "UPDATE Table_Review SET review = @addReview  WHERE reviewId = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", reviewDAL.ReviewId);
            cmd.Parameters.AddWithValue("@addReview", reviewDAL.AddReview);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
      



    }
}
