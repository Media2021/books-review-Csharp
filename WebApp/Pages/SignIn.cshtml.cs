using BookReviews;
using BookReviews.classes;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WebApp.Pages
{
    
    public class SignInModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();


        [BindProperty]
        public   User? user { get; set; }

        [BindProperty]

        public List<User> users { get; set; }   

        public void OnGet()
        {
            
        }
        public void OnPost()
        {
           
            
        }
    }
   }

