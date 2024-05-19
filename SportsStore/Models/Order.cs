using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
            = new List<CartLine>();
        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 {  get; set; }
        public string? Line3 { get; set; }
        [Required(ErrorMessage = "Please enter city.")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Please enter a state or region.")]
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter a country.")]
        public string? Country {  get; set; }
        public bool GiftWrap { get; set; }
    }
}
