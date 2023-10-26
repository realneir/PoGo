using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASI.Basecode.Services.Models
{

    public class GenreViewModel
    {
        [JsonPropertyName("genreID")]
        public int genreID { get; set; }

        [JsonPropertyName("genreName")]
        [Required(ErrorMessage = "Genre Name is required.")]
        public string genreName { get; set; }
    }
}