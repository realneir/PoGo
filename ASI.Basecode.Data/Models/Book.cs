using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public class Book
    {
        public int bookID { get; set; }
        public int authorID { get; set; }
        public int genreID { get; set; }
        public string title { get; set; }
        public string description { get; set; }


        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
       // public virtual ICollection<Review> Reviews { get; set; } 
    }
}
