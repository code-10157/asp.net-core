using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }　//日付

        //[Column(TypeName = "varchar(10)")]
        public string Genre { get; set; } //種類
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } //価格
    }
}