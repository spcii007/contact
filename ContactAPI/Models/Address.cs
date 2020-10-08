using System.ComponentModel.DataAnnotations;

public class Address {

  [Key]
  public int Id { get; set; }

  [Required]
  [MaxLength (250)]
  public string street { get; set; }

  [Required]
  [MaxLength (100)]
  public string city { get; set; }

  [Required]
  [MaxLength (80)]
  public string state { get; set; }

  [MaxLength (5)]
  public string zip { get; set; }

}