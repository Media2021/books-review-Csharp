using BookReviews.classes;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Mapper
{
    public static class MapToDAL
    {
        public static BookEntity 
            MapToBookDAL(Book book)
        {
            return new BookEntity(book.Id,book.Title,book.Author,book.Type,book.Description);
        }
        public static Book MapToBook(BookEntity book)
        {
            return new Book(book.Id, book.Title, book.Author, book.Type, book.Description);
        }



        public static EmpEntity MapToEmpDAL(Employee employee)
        {
            return new EmpEntity (employee.ID,employee.Name,employee.Password,employee.BSN1,employee.Role);
        }
        public static Employee MapToEmp(EmpEntity employee)
        {
            return new Employee (employee.Id, employee.Name, employee.Password, employee.BSN1, employee.Role);

        }



        public static UsercEntity MapToUserDAL(User user)
        {
            return new UsercEntity(user.ID, user.Name, user.Password, user.ExpirationDate);
        }
        public static User MapToUser(UsercEntity user)
        {
            return new User(user.Id, user.Name, user.Password, user.ExpirationDate);
        }


    }
}
