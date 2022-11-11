using BookReviews.classes;
using BookReviews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;
using WebApp.DTO.DTOMapper;
using DBlayer;

namespace WebApp.Pages
{
    public class EditMyReviewModel : PageModel
    {
        BookManager bookManager = new BookManager();
        //PeopleManager peopleManager = new PeopleManager();
        static PersonDB personDB = new PersonDB();
        PeopleManager peopleManager = new PeopleManager(personDB);
        [BindProperty]

        public List<Review> Reviews { get; set; }
        [BindProperty]
        public List<ReviewDTO> reviewDTO { get; set; }
        [BindProperty]
        public string Id { get; set; }
        [BindProperty]
        public Book book { get; set; }
        public void OnGet()
        {
            List<Review>  filteredRew = bookManager.GetReviews().FindAll(x=>x.User1.Name==User.Identity.Name);
            reviewDTO = new List<ReviewDTO>();
            foreach (Review review in filteredRew)
            {
                reviewDTO.Add(Mapper.mapToReviewDTO(review));
            }

            


        }

        public void OnPost(int id)
        {
          


        }
    }
}
