using BookReviews;
using BookReviews.classes;
using DAO;
using DBlayer;
using LogicLayer.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;

namespace WebApp.Pages
{
      
    public class AddReviewModel : PageModel
    {
        BookManager bookManager = new BookManager();
        //PeopleManager peopleManager = new PeopleManager();
        static PersonDB personDB = new PersonDB();
        PeopleManager peopleManager = new PeopleManager(personDB);
        [BindProperty]

        public List<Review> Reviews { get; set; } 
        [BindProperty]
        public ReviewDTO reviewDTO { get; set; }
        [BindProperty]
        public string Id { get; set; }
        [BindProperty]
        public Book book { get; set; }



        public void OnGet(string Id )
        {
            List<Book> books = bookManager.GetBooks();
            this.Id = Id;
            book = books.Find(x => x.Id == this.Id);

            Reviews = bookManager.GetReviews();



        }


        public IActionResult OnPost()
        {
            //if (ModelState.IsValid)
            //{
                //if (Review != null)
                
                    Person person = peopleManager.GetLoggedInUser(reviewDTO.User1);


                    Review review = new Review(reviewDTO.Id, reviewDTO.Title, (User)person, reviewDTO.AddReview, DateTime.Now);

                    bookManager.AddReview(review);


                    return Page();



                    ViewData["Message"] = "Hello" + User.Identity.Name + " Your review has been created ";
                
            //}
                return RedirectToPage("/MainHTML");
        }
        public IActionResult OnPostDelete()
        {
            

            return RedirectToPage("/Error");
        }
    }
}
