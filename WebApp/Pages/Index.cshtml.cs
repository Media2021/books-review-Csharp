using BookReviews.classes;
using BookReviews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        BookManager bookManager = new BookManager();

        [BindProperty]
        public List<Review> Reviews { get; set; }

        [BindProperty]
        public Review? Review { get; set; }
        [BindProperty]

        public List<Book>? books { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Reviews = bookManager.GetReviews();
            books = bookManager.GetBooks();

        }
    }
}