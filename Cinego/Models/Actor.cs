#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Cinego.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }
        [Display(Name="Picture")]
        [Required(ErrorMessage="Picture is required!")]
        public string PpURL { get; set; }
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage ="Name Surname are required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Minimum length is 3 character at least")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }
        //rel
        public List<Actor_Movie> Actors_Movies { get; set; }
        
    }
}
