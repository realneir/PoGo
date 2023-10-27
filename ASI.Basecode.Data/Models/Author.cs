using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Author
    {
        public int authorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


        public virtual ICollection<Book> Books { get; set; }
    }
}
