using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASI.Basecode.Data.Models
{
    public class Book
    {
        public int bookID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string Image { get; set; }
        public DateTime pubYear { get; set; }


        [ForeignKey("Author")]
        public int authorId { get; set; }
        public virtual Author Author { get; set; }
        [ForeignKey("Genre")]
        public int genreId { get; set; }
        public virtual Genre Genre { get; set; }
       // public virtual ICollection<Review> Reviews { get; set; } 
    }
}
