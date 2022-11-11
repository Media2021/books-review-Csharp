
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBlayer;
using LogicLayer.Mapper;
using System.Text.RegularExpressions;

namespace BookReviews.classes
{
    public  class BookManager
    {
        BooksDB BooksDB = new BooksDB();
        List<Book> books = new List<Book>();
       List <Review> reviews = new List<Review> ();

        
        
    public BookManager()
    {
            books.Clear();
            UpdateBooks(); 
            reviews.Clear();
            UpdateReviews();
    }
        public List<Book> GetBooks()
        { 
            return books;
        }
        public void UpdateBooks()
        {
            books.Clear();
            List<BookEntity> booksEntity = BooksDB.ReadBook();
            foreach (var bookEntity in booksEntity)
            {
                Book book = MapToDAL.MapToBook(bookEntity);
                books.Add(book);
            }


        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
            BookEntity bookEntity = MapToDAL.MapToBookDAL(book);
            BooksDB.DeleteBook(bookEntity);
        }

        public void Addbook(Book book)
        {
            books.Add(book);
            BookEntity bookEntity = MapToDAL.MapToBookDAL(book);
            BooksDB.CreateBook(bookEntity
                );
        }



        public List<Review> GetReviews()
        {
            return reviews;
        }
        public void UpdateReviews()
        {
            reviews.Clear();
            List<ReviewEntity> reviewsEntity = BooksDB.ReadReviews();
            foreach (var reviewEntity in reviewsEntity)
            {
                Review review = MapToDAL.MapToReview(reviewEntity);
                reviews.Add(review);
            }


        }
        public void AddReview(Review review)
        {
            reviews.Add(review);
            ReviewEntity reviewEntity = MapToDAL.MapToReviewDAL(review);
            BooksDB.CreateBookReview(reviewEntity );
        }
        public void DeleteReview(Review review)
        {
            reviews.Remove(review);
            ReviewEntity reviewEntity = MapToDAL.MapToReviewDAL(review);
            BooksDB.DeleteReview(reviewEntity);
        }
        public void EditMyReview(Review review)
        {


            

            ReviewEntity reviewEntity = MapToDAL.MapToReviewDAL(review);
            BooksDB.UpdateReview(reviewEntity);
        }
        public void EditingReview(Review review)
        {
            string[] listWords = { "fuck", "shit", "bitch"};
         
            string[] words = review.AddReview.Split(' ');

            foreach (var word in words)
            {
                foreach (var badWord in listWords)
                {
                    if (word.Contains(badWord))
                    {
                       string a = review.AddReview.Replace(word, "***");
                        review.AddReview = a;
                    }
                }                  
                
            }           

            ReviewEntity reviewEntity = MapToDAL.MapToReviewDAL(review);
            BooksDB.UpdateReview(reviewEntity);

        }
        //public void Test(Review user)
        //{

        //}

    }
   
}
