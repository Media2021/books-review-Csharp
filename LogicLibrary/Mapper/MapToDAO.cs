using BookReviews.classes;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Mapper
{
    public static class MapToDAO
    {
        public static BookDAL 
            MapToBookDAO(Book book)
        {
            return new BookDAL(book.Id,book.Title,book.Author,book.Type,book.Description);
        }
        public static Book MapToBook(BookDAL book)
        {
            return new Book(book.Id, book.Title, book.Author, book.Type, book.Description);
        }


        public static EmpDAL MapToEmpDAO(Employee employee)
        {
            return new EmpDAL (employee.ID,employee.Name,employee.Password,employee.BSN1,employee.Role);
        }
        public static Employee MapToEmp(EmpDAL employee)
        {
            return new Employee (employee.Id, employee.Name, employee.Password, employee.BSN1, employee.Role);

        }


    }
}
