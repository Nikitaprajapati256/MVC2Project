
using System.ComponentModel.DataAnnotations;


namespace MVC2Project.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }
        [Required]
        public String CategoryName { get; set; }
    }
}
