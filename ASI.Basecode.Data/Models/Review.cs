using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    class Review
    {
        public int ReviewNum { get; set; }
        public int BookID { get; set; }
      
        public string Content { get; set; }
        
        public int Rating { get; set; }
        public string ReviewName { get; set; }
       
        public string ReviewEmail { get; set; }
        public virtual Book Book { get; set; }
    }
}
