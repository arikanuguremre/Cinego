#nullable disable

using Cinego.Data;
using Cinego.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinego.Models
{
    public class Movie
	{
		[Key]
        public int Id { get; set; }
        [Display(Name = "Banner")]
        [Required(ErrorMessage = "Banner is required!")]
        public string ImageURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required!")]

        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required!")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }

        public DateTime StartDate { get; set; }
		public DateTime FinishDate { get; set; }
		public MovieType MoviType { get; set; }

		public List<Actor_Movie> Actors_Movies { get; set; }

		public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
		
		public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }

	}
}
