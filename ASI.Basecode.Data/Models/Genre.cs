using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public class Genre
    {
        public int genreID { get; set; }
        public string genreName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
