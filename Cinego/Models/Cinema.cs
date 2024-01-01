#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Cinego.Models
{
	public class Cinema
	{
        [Key]
        public int Id { get; set; }
        [Display(Name = "Brand Logo")]
        [Required(ErrorMessage = "Brand logo is required!")]
        public string Brandlogo { get; set; }
        [Display(Name = "Place Name")]
        [Required(ErrorMessage = "Place name  is required!")]
        public string Name { get; set; }
        [Display(Name = "Adress")]
        [Required(ErrorMessage = "Address is required!")]
        public string CinemaInfo { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
