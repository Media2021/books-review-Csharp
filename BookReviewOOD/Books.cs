using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews
{
    public class Books
    {
        public int id;//Book Id
        public string title;
        public string author;  
        public string type;
        public string description;
        private List<Review> reviews;

        public Books()
        {
        }

        public Books(int id,string title, string author,string type ,string description )
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.type = type;
            this.description = description;
            reviews = new List<Review>();
         
          
        }   

        public int Id { get { return id; } }    
        public string Title { get { return title; } }
        public string Author { get { return author; } }

        public string Type { get { return type; } }

        public string Description { get { return description; } }

        public List<Review> Reviews { get => reviews; set => reviews = value; }


        
    }
}
