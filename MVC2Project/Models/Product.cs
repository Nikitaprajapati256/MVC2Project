using System.ComponentModel.DataAnnotations;

namespace MVC2Project.Models
{
    public class Product
    {
        [ScaffoldColumn(false)] // do not want to generate field when creating template using scffold technique
        public int Id { get; set; }
        [Required]
         public string Name { get; set; }
        [Required]
         public string Company { get; set; }
        [Required]
        public int   Price { get; set; }
    }
}
