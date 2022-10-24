using BookReviews.classes;
using BookReviews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class BooksCllectionModel : PageModel
    {
        BookManager bookManager = new BookManager();

        [BindProperty]
        public Review? Review { get; set; }
        [BindProperty]

        public List<Book>? books { get; set; }
        public void OnGet()
        {
            books = bookManager.GetBooks();

        }
      
    }
}
