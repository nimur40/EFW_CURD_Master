using System.ComponentModel.DataAnnotations;

namespace Online_Shop_EFW.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }//porp
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
