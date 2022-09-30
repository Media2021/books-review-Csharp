using BookReviews.classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Person? Person { get; set; }
        public void OnGet()
        {
          
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Person != null)
                {

                    ViewData["Message"] = "Hello" + Person.Name + " Your account has been created " ;
                }
            }
        }
    }
}
