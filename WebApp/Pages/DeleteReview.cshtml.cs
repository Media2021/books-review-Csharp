using BookReviews;
using BookReviews.classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;
using WebApp.DTO.DTOMapper;

namespace WebApp.Pages
{
    public class DeleteReviewModel : PageModel
    {

        BookManager bookManager = new BookManager();

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

            bookManager.DeleteReview(review);
            return new RedirectToPageResult($"/EditMyReview");

        }
    }
}
