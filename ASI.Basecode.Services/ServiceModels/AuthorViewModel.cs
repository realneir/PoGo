using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASI.Basecode.Services.Models
{
    public class AuthorViewModel
    {
        [JsonPropertyName("authorID")]
        public int authorID { get; set; }

        [JsonPropertyName("firstName")]
        [Required(ErrorMessage = "First name is required.")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        [Required(ErrorMessage = "Last name is required.")]
        public string lastName { get; set; }
    }
}