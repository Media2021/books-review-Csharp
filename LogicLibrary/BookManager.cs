
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBlayer;
using LogicLayer.Mapper;

namespace BookReviews.classes
{
    public  class BookManager
    {
        BooksDB BooksDB = new BooksDB();
        List<Book> books = new List<Book>();
        

        
        
    public BookManager()
    {
            books.Clear();
            UpdateBooks();          

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
        


    }
   
}
