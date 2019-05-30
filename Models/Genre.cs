using System.ComponentModel.DataAnnotations;

namespace DOtNet_05.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}
