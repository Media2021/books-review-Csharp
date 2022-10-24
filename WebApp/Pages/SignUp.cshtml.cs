using BookReviews;
using BookReviews.classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;

namespace WebApp.Pages
{
    public class SignUpModel : PageModel
    {
       
        PeopleManager peopleManager = new PeopleManager();

        [BindProperty]
        public UserDto user { get; set; }
      
        public void OnGet()
        {
          
        }
        public IActionResult OnPost()
        {
           
           
            if (ModelState.IsValid == true)
            {
                User savedUser = new User(user.Name,user.Password);
                
                peopleManager.AddUser(savedUser);

                return Page();

                ViewData["Message"] = "Hello" + user.Name + " Your account has been created ";
            }
            return RedirectToPage("/SignIn");
            
        }
    }
}
