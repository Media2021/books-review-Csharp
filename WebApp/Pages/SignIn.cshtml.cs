using BookReviews;
using BookReviews.classes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Claims;
using System.Xml.Linq;
using WebApp.DTO;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Pages
{
    
    public class SignInModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();
         public Person person { get; set; } 


        [BindProperty]
        public   UserDto userDTO { get; set; }
        
        public void OnGet()
        {
           
        }
        public IActionResult  OnPost()
        {
         
            
            bool result = peopleManager.Login(userDTO.Name, userDTO.Password);
           


            if (result)
            {
                person = peopleManager.GetLoggedInUser(userDTO.Name);
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, userDTO.Name));
                claims.Add(new Claim("id", ""+person.ID));

                



                if (person is Employee)

                {
                    

                    claims.Add(new Claim(ClaimTypes.Role, "Employee"));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    return new RedirectToPageResult("/BooksCollection");
                }
                else 
                {
                    


                    return new RedirectToPageResult($"/MainHTML");

                }

            }
            else
            {
                //Username or pass wrong
            }
            return Page();

           

        }
    }
   }

