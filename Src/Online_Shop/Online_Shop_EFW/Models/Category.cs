using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Online_Shop_EFW.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }//porp
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
