using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    class Review
    {
        public int reviewID { get; set; }
      
        public string content { get; set; }
        
        public int rating { get; set; }
        public string reviewName { get; set; }
       
        public string reviewEmail { get; set; }
        [ForeignKey("Author")]
        public int bookID { get; set; }
        public virtual Book Book { get; set; }
    }
}
