using BookReviews.classes;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Mapper
{
    public static  class MapToPeople
    {
        public static User MapToUserDAL(UsercEntity user)
        {
            return new User(user.Id, user.Name, user.Password, user.ExpirationDate);
        }
    }
}
