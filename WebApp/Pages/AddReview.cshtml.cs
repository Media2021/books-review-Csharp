using BookReviews;
using BookReviews.classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class AddReviewModel : PageModel
    {
        
        BookManager bookManager = new BookManager();
        PeopleManager peopleManager = new PeopleManager();  
        [BindProperty]
        public Review? Review { get; set; }
       
        [BindProperty]
        public string Id { get; set; }
        [BindProperty]
        public Book book { get; set; }
        [BindProperty]

        public string username { get; set; }


        [BindProperty]

        public User user { get; set; }
       

        public void OnGet(string Id,string username)
        {
            List<Book> books=bookManager.GetBooks();
            this.Id = Id;
            book = books.Find(x => x.Id == this.Id);


            user = (User)peopleManager.GetLoggedInUser(username);
            this.username = username;
            

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
