using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Name {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string first { get; set; }
        [MaxLength(100)]
        public string middle { get; set; }
        [MaxLength(100)]
        public string last { get; set; }
    }
}