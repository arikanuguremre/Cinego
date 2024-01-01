using Cinego.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cinego.Data.ViewModel
{
    public class FreshMovie
    {
        [Display(Name = "Banner")]
        [Required(ErrorMessage = "Banner is required!")]
        public string ImageURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required!")]

        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start date is required!")]

        public DateTime StartDate { get; set; }
        [Display(Name = "Finish Date")]
        [Required(ErrorMessage = "Finish date is required!")]

        public DateTime FinishDate { get; set; }
        [Display(Name = "Movie Type")]
        [Required(ErrorMessage = "Movie Type is required!")]

        public MovieType MoviType { get; set; }
        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Actor is required!")]

        public List<int> ActorsIds { get; set; }
        [Display(Name = "Select Cinema")]
        [Required(ErrorMessage = "Cinema id is required!")]

        public int CinemaId { get; set; }

        [Display(Name = "Select Director")]
        [Required(ErrorMessage = "Director is required!")]
        public int DirectorId { get; set; }
    }
}
