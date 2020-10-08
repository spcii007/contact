using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Models {
    public class Phone {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string number { get; set; }
        public phonetype phoneType { get; set; }

        public string type {
            get {
                return phoneType.ToString();
            }
        }
        public int PersonId { get; set; }

    }
}