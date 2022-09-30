using BookReviews;
using BookReviews.classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class AddReviewModel : PageModel
    {
        BookManager bookManager = new BookManager();

        [BindProperty]
        public Review? Review { get; set; }
        [BindProperty]
        public List<Book> books { get; set; }
        public void OnGet()
        {
            books=bookManager.GetBooks();

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Review != null)
                {

                    ViewData["Message"] = "Hello" + Review.Id + " Your review has been posted ";
                    //bookManager.Addbook(new Book());
                }
            }
        }
    }
}
