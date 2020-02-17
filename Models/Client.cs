using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ruler.Models
{
  [Table("Client")]
  public class Client
  {
    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Name { get; set; }

    [MaxLength(12)]
    [Display(Name = "Registry Code")]
    public string RegistryCode { get; set; }

    [MaxLength(12)]
    [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
    public string Phone { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Updated At")]
    public DateTime? UpdatedAt { get; set; }

    public Client()
    {
      UpdatedAt = DateTime.UtcNow.AddHours(-3);
    }
  }
}