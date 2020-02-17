using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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
    [DefaultValue("getutcdate()")]
    public DateTime? UpdatedAt { get; set; }
  }
}