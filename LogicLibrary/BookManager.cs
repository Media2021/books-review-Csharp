
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
            List<BookDAL> booksDAO = BooksDB.ReadBook();
            foreach (var bookDao in booksDAO)
            {
                Book book = MapToDAO.MapToBook(bookDao);
                books.Add(book);
            }


        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
            BookDAL bookDAO = MapToDAO.MapToBookDAO(book);
            BooksDB.DeleteBook(bookDAO);
        }

        public void Addbook(Book book)
        {
            books.Add(book);
            BookDAL bookDAO = MapToDAO.MapToBookDAO(book);
            BooksDB.CreateBook(bookDAO);
        }
        


    }
   
}
