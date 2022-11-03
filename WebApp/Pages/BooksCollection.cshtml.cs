using BookReviews.classes;
using BookReviews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Pages
{
    [Authorize(Policy = "OnlyEmployeeAccess")]
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
