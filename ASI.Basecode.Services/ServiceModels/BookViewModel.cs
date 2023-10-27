using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.ServiceModels
{
    public class BookViewModel
    {
        [JsonPropertyName("bookID")]
        [Required(ErrorMessage = "Book ID is required.")]
        public string bookID { get; set; }

        [JsonPropertyName("authorId")]
        [Required(ErrorMessage = "Author is required.")]
        public int authorID { get; set; }

        [JsonPropertyName("genreID")]
        [Required(ErrorMessage = "Genre is required.")]
        public int genreID { get; set; }

        [JsonPropertyName("title")]
        [Required(ErrorMessage = "Book title is required.")]
        public string title { get; set; }

        [JsonPropertyName("description")]
        [Required(ErrorMessage = "Book description is required.")]
        public string description { get; set; }

        [JsonPropertyName("pubYear")]
        [Required(ErrorMessage = "Publishing year is required.")]
        public DateTime pubYear { get; set; }
    }
}