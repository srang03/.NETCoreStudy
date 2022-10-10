using System.ComponentModel.DataAnnotations;

namespace MVCBookWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
