using ContactAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Models {
    public class Person {

        [Key]
        public int Id { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Phone> Phone { get; set; }        

        [MaxLength (100)]
        public string Email { get; set; }
    }
}