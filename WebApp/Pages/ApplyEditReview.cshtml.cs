using BookReviews.classes;
using BookReviews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;
using WebApp.DTO.DTOMapper;
using DBlayer;

namespace WebApp.Pages
{
    public class ApplyEditReviewModel : PageModel
    {
        BookManager bookManager = new BookManager();
        //PeopleManager peopleManager = new PeopleManager();
        static PersonDB personDB = new PersonDB();
        PeopleManager peopleManager = new PeopleManager(personDB);

        Review review;
        [BindProperty]
        public ReviewDTO reviewDTO { get; set; }
        public int id { get; set; }
        public void OnGet(int id)
        {
            List<Review> reviews = bookManager.GetReviews();

            this.id = id;
            review = reviews.Find(x => x.ReviewId == this.id);
            reviewDTO = Mapper.mapToReviewDTO(review);
        }

        public IActionResult OnPost(int id)
        {
            List<Review> reviews = bookManager.GetReviews();

            this.id = id;
            review = reviews.Find(x => x.ReviewId == this.id);
            User user = (User)peopleManager.GetPeople().Find(x=>x.Name==reviewDTO.User1);

            Review newReview = Mapper.mapToReview(reviewDTO,user);
            //bookManager.Test(newReview);

            bookManager.EditMyReview(newReview);
            return new RedirectToPageResult($"/EditMyReview");


        }
    }
}
