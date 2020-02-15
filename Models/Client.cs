using System;
using System.Collections.Generic;
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
    public string RegistryCode { get; set; }

    [MaxLength(12)]
    public string Phone { get; set; }
  }
}