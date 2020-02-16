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
    public int RegistryCode { get; set; }

    [MaxLength(30)]
    public string Brand { get; set; }

    public Single Price { get; set; }

    [MaxLength(255)]
    public string Label { get; set; }

    [MaxLength(12)]
    public int Lot { get; set; }
   
    public DateTime ManufactDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

  }
}