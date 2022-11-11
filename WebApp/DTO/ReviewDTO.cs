using DAO;

namespace WebApp.DTO
{
    public class ReviewDTO
    {
        private int reviewId;
        private string id;
        private string title;// 
        //private  User user;
        private string user1;
        private string addReview;
        private DateTime date;

        public ReviewDTO()
        {           
        }


        public int ReviewId { get => reviewId; set => reviewId = value; }
        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string User1 { get => user1; set => user1 = value; }
        public string AddReview { get => addReview; set => addReview = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
