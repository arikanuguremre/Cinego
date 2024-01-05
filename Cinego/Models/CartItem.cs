using System.ComponentModel.DataAnnotations;

namespace Cinego.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public string CartId { get; set; }


    }
}
