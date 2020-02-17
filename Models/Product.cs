using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruler.Models
{
  [Table("Product")]
  public class Product
  {
    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Name { get; set; }

    [MaxLength(12)]
    [Display(Name = "Registry Code")]
    public string RegistryCode { get; set; }

    [MaxLength(30)]
    public string Brand { get; set; }

    [DataType(DataType.Currency)]
    public Double? Price { get; set; }

    [MaxLength(255)]
    public string Label { get; set; }

    [MaxLength(12)]
    public string Lot { get; set; }

    [MaxLength(30)]
    public string Category { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Manufact Date")]
    public DateTime? ManufactDate { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Expiry Date")]
    public DateTime? ExpiryDate { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Updated At")]
    public DateTime? UpdatedAt { get; set; }

    public Product()
    {
      UpdatedAt = DateTime.UtcNow.AddHours(-3);
    }

  }
}