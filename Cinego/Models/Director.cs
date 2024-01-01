#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cinego.Models
{
	public class Director
	{
		[Key]
        public int Id { get; set; }
		[Display(Name ="Picture")]
        [Required(ErrorMessage = "Picture is required!")]
        public string PpURL { get; set; }
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Name/Surname is required!")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio is required!")]
        public string Bio { get; set; }

        //rel
        public List<Movie> Movies{ get; set; }
    }
}

