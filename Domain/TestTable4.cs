using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class TestTable4
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
